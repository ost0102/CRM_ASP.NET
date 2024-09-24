Public Class FreightCommon

    Enum FreightPoint
        _445 = 1
        Round = 1
    End Enum


    Public Shared Function VatCalculator(ByVal Amount As Object, ByVal Percent As Object, ByVal RoundType As Object)
        Dim Vat As Decimal = 0.0
        Dim mAmount As Decimal = 0.0
        Dim mPercent As Decimal = 0.0
        Dim mDcmPoint As Integer = ClientSessionOfficeInfo.DecimalPoint

        Try
            If Not IsDBNull(Amount) AndAlso Amount.ToString <> "" AndAlso IsNumeric(Amount) Then
                mAmount = Amount
            End If
            If Not IsDBNull(Percent) AndAlso Percent.ToString <> "" AndAlso IsNumeric(Percent) Then
                If Percent <> 0 Then
                    mPercent = Percent / 100
                End If
            End If
            Vat = mAmount * mPercent

            If ClientSessionOfficeInfo.CountryCode = "KR" And RoundType <> "N" And RoundType <> "" Then
                Vat = CustomerRound(Vat, RoundType)
            Else
                Vat = Math.Round(Vat, mDcmPoint, MidpointRounding.AwayFromZero)
            End If

        Catch ex As Exception

        End Try


        Return Vat
    End Function



    Public Shared Function AmountCalculator(ByVal QTY As Object, _
                                            ByVal Rate As Object, _
                                            ByVal CurrCd As String, _
                                            ByVal RoundType As Object, _
                                            Optional LocFrgnType As String = Nothing)
        Dim Amount As Decimal = 0.0
        Dim mQTY As Decimal = 0.0
        Dim mRate As Decimal = 0.0
        Dim mTemp As Decimal = 0.0

        Dim mDcmPoint As Integer = ClientSessionOfficeInfo.DecimalPoint

        Try
            mQTY = TryCDec(QTY)
            mRate = TryCDec(Rate)

            If ClientSessionOfficeInfo.HqOfficeCode = "ECOHQ" Then
                'EX) 0.096 X 6.3 = 0.6048  -> POLARIS 는 0.61로 보여집니다. (실제 0.60으로 되어야 합니다. 3자리반올림이므로) 
                Amount = Math.Truncate((mQTY * mRate) * Math.Pow(10, 3)) / Math.Pow(10, 3)
            Else
                Amount = Math.Round(mQTY * mRate, 3, MidpointRounding.AwayFromZero)
            End If

            If (LocFrgnType <> "F") AndAlso (ClientSessionOfficeInfo.CurrencyCode = CurrCd) Then
                Amount = 0
            Else
                If CurrCd = ClientSessionOfficeInfo.CurrencyCode Then
                    If ClientSessionOfficeInfo.CountryCode = "KR" And RoundType <> "N" And RoundType <> "" Then
                        Amount = CustomerRound(Amount, RoundType)
                    Else
                        Amount = Math.Round(Amount, mDcmPoint, MidpointRounding.AwayFromZero)
                    End If
                Else
                    Amount = Math.Round(Amount, 2, MidpointRounding.AwayFromZero)
                End If
            End If

        Catch ex As Exception

        End Try
        Return Amount
    End Function


    Public Shared Function LocalAmountCalculator(ByVal OfficeCd As String, _
                                                 ByVal LocCurrCd As String, _
                                                 ByVal CurrCd As String, _
                                                 ByVal ExRate As Object, _
                                                 ByVal Amount As Object, _
                                                 ByVal RoundType As Object, _
                                                 Optional LocFrgnType As String = Nothing, _
                                                 Optional Pkg As Object = Nothing, _
                                                 Optional UnitPrc As Object = Nothing)
        Dim ExAmount As Decimal = 0.0
        Dim mExRate As Decimal = 0.0
        Dim mAmount As Decimal = 0.0
        Dim dsRet As DataSet
        Dim params As Object = {OfficeCd, LocCurrCd, CurrCd}
        Dim dcmPoint As Integer = ClientSessionOfficeInfo.DecimalPoint
        Dim mPkg As Decimal = 0.0
        Dim mUnitPrc As Decimal = 0.0
        Dim CurrUnit As Decimal = 0.0

        mPkg = TryCDec(Pkg)
        mUnitPrc = TryCDec(UnitPrc)

        Try

            If (LocFrgnType <> "F") AndAlso (ClientSessionOfficeInfo.CurrencyCode = CurrCd) Then
                If ClientSessionOfficeInfo.CountryCode = "KR" And RoundType <> "N" And RoundType <> "" Then
                    ExAmount = CustomerRound(mPkg * mUnitPrc, RoundType)
                Else
                    ExAmount = Math.Round(mPkg * mUnitPrc, dcmPoint, MidpointRounding.AwayFromZero)
                End If
            Else
                dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetCurrUnit", params)
                Dim RtDr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
                CurrUnit = RtDr("CURR_UNIT")
                mExRate = TryCDbl(ExRate)
                mAmount = TryCDbl(Amount)

                ExAmount = mExRate * mAmount / CurrUnit

                If ClientSessionOfficeInfo.CountryCode = "KR" And RoundType <> "N" And RoundType <> "" Then
                    ExAmount = CustomerRound(ExAmount, RoundType)
                Else
                    ExAmount = Math.Round(ExAmount, dcmPoint, MidpointRounding.AwayFromZero)
                End If
            End If


        Catch ex As Exception

        End Try
        Return ExAmount
    End Function

    Public Shared Function GetExRate(ByVal OfficeCd As String, ByVal BaseCurrCd As String, ByVal Curr_cd As String, ByVal ExRateYmd As String, ByVal ServiceType As String, ByVal SellBuyType As String)
        Dim RerturnValue(2) As String
        RerturnValue(0) = 0
        RerturnValue(1) = 0
        RerturnValue(2) = ""

        Dim dsRet As DataSet
        Dim params As Object = {OfficeCd, BaseCurrCd, Curr_cd, ExRateYmd, ServiceType, SellBuyType}
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetExRate", params)
            Dim RtDr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
            RerturnValue(0) = RtDr("CURR_UNIT")
            RerturnValue(1) = RtDr("EXRATE")
            RerturnValue(2) = RtDr("EXRATE_CLASS")
        Catch ex As Exception
            If ClientSessionInfo.UserID.ToUpper = "ADMIN" Then DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RerturnValue(0) = -1
            RerturnValue(1) = -1
            RerturnValue(2) = "A"
        End Try
        Return RerturnValue
    End Function

    ' Customer 별 환율조회
    Public Shared Function GetCustExRate(ByVal CustomerCd As String, ByVal BaseCurrCd As String, ByVal Curr_cd As String, ByVal ExRateYmd As String, _
                                         ByVal ServiceType As String, ByVal SellBuyType As String)
        Dim RerturnValue(2) As String
        RerturnValue(0) = 0
        RerturnValue(1) = 0
        RerturnValue(2) = ""

        Dim dsRet As DataSet
        Dim params As Object = {CustomerCd, BaseCurrCd, Curr_cd, ExRateYmd, ServiceType, SellBuyType}
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetCustExRate", params)
            Dim RtDr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
            RerturnValue(0) = RtDr("CURR_UNIT")
            RerturnValue(1) = RtDr("EXRATE")
            RerturnValue(2) = RtDr("EXRATE_CLASS")
        Catch ex As Exception
            If ClientSessionInfo.UserID.ToUpper = "ADMIN" Then DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RerturnValue(0) = -1
            RerturnValue(1) = -1
            RerturnValue(2) = "A"
        End Try
        Return RerturnValue
    End Function

    Public Shared Function CustomerRound(ByVal Amt As Object, ByVal RoundType As String)
        Dim rtnAmt As Decimal = 0.0
        Dim Amount As Decimal = 0.0
        Amount = CDec(Amt)


        Select Case RoundType
            Case "1"  ' 소숫점 1 자리 사사오입
                ' rtnAmt = Math.Round(Math.Truncate(Amount * Math.Pow(10, 1)) / Math.Pow(10, 1))
                rtnAmt = Math.Round(Math.Truncate(Amount * 10) / 10, System.MidpointRounding.AwayFromZero)
            Case "2"  '소숫점 버림
                rtnAmt = Math.Truncate(Amount)
            Case "3"  '단자리 사사오입
                'rtnAmt = Math.Round(Amount / 10) * Math.Pow(10, 1)
                rtnAmt = Math.Round(Amount / 10, System.MidpointRounding.AwayFromZero) * 10
            Case "4"  ' 단자리 버림
                'rtnAmt = Math.Truncate(Amount / Math.Pow(10, 1)) * Math.Pow(10, 1)
                rtnAmt = Math.Truncate(Amount / 10) * 10
            Case "5" ' 소숫점 1 자리 사사오입후 단자리 사사오입
                'rtnAmt = Math.Round(Math.Truncate(Amount * Math.Pow(10, 1)) / Math.Pow(10, 1))
                'rtnAmt = Math.Round(rtnAmt / 10) * Math.Pow(10, 1)
                rtnAmt = Math.Round(Math.Truncate(Amount * 10) / 10, System.MidpointRounding.AwayFromZero)
                rtnAmt = Math.Round(rtnAmt / 10, System.MidpointRounding.AwayFromZero) * 10
            Case Else ' 소숫점 1 자리 사사오입후 단자리 버림
                'rtnAmt = Math.Round(Math.Truncate(Amount * Math.Pow(10, 1)) / Math.Pow(10, 1))
                rtnAmt = Math.Round(Math.Truncate(Amount * 10) / 10, System.MidpointRounding.AwayFromZero)
        End Select


        Return rtnAmt

    End Function



End Class
