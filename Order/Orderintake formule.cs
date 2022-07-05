=SOMMEN.ALS((INDIRECT(RidderOrderData!$L$4));
            (INDIRECT(RidderOrderData!$L$5));"="&MAAND($A5);
            (INDIRECT(RidderOrderData!$L$6));"="&JAAR($A5);
            (INDIRECT(RidderOrderData!$L$3));"="&D$2&"*")
            

=SOMMEN.ALS(RidderOrderData!$C$1:"C"&RidderOrderData!$K$2;
            RidderOrderData!$E$1:"E"&"250";"="&MAAND($A5);
            RidderOrderData!$F$1:"F"$250;"="&JAAR($A5))


=AANTALLEN.ALS( (INDIRECT(RidderOfferteData!$L$7));"="&B$2;
                (INDIRECT(RidderOfferteData!$L$3));"="&$B$1&"*";
                (INDIRECT(RidderOfferteData!$L$5));"="&($A3);
                (INDIRECT(RidderOfferteData!$L$6));"=2019")
