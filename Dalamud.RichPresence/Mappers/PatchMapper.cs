namespace Dalamud.RichPresence.Mappers
{
    internal class PatchMapper
    {
        public static string GetPatch(ulong id)
        {
            switch (id) {
                case >= 128 and <= 142:
                case >= 144 and <= 149:
                case >= 151 and <= 156:
                case >= 159 and <= 160:
                case >= 162 and <= 163:
                case 167:
                case >= 170 and <= 172:
                case 174:
                case >= 176 and <= 183:
                case >= 190 and <= 192:
                case 198:
                case >= 204 and <= 205:
                case 210:
                case 212:
                case >= 214 and <= 216:
                case >= 219 and <= 223:
                case >= 225 and <= 245:
                case >= 248 and <= 280:
                case >= 282 and <= 294:
                case >= 298 and <= 331:
                case 335:
                case >= 338 and <= 347:
                case >= 353 and <= 354:
                case 379:
                case >= 384 and <= 386:
                case >= 392 and <= 393:
                case >= 404 and <= 415:
                case >= 453 and <= 454:
                case 456:
                case 460:
                case >= 465 and <= 466:
                case >= 468 and <= 469:
                case 471:
                case >= 473 and <= 475:
                case 480:
                case >= 483 and <= 484:
                case >= 486 and <= 488:
                case 491:
                case >= 494 and <= 496:
                case 500:
                case 666:
                case >= 668 and <= 669:
                case 672:
                case 675:
                case 699:
                case 721:
                case 728:
                case >= 832 and <= 833:
                case 839:
                case 865:
                case 867:
                case >= 1032 and <= 1034:
                case >= 1036 and <= 1049:
                case >= 1052 and <= 1053:
                case >= 1058 and <= 1060:
                    return "2.0";
                case >= 295 and <= 297:
                case >= 348 and <= 351:
                case >= 368 and <= 369:
                case 1067:
                    return "2.1";
                case 281:
                case >= 355 and <= 360:
                case >= 362 and <= 364:
                case 366:
                case 704:
                    return "2.2";
                case 361:
                case 365:
                case >= 372 and <= 376:
                case >= 380 and <= 383:
                case 490:
                case 502:
                    return "2.3";
                case >= 193 and <= 196:
                case >= 246 and <= 247:
                case 367:
                case 370:
                case >= 377 and <= 378:
                case 387:
                case 457:
                case 1062:
                    return "2.4";
                case >= 188 and <= 189:
                case 394:
                case 396:
                case 426:
                case 569:
                case 1063:
                    return "2.5";
                case >= 388 and <= 391:
                case 417:
                case 506:
                case 579:
                case 831:
                case >= 940 and <= 941:
                    return "2.51";
                case 395:
                case 1068:
                    return "2.55";
                case >= 397 and <= 402:
                case >= 418 and <= 420:
                case >= 423 and <= 425:
                case >= 427 and <= 430:
                case >= 432 and <= 434:
                case >= 436 and <= 437:
                case >= 439 and <= 440:
                case >= 446 and <= 447:
                case 455:
                case >= 458 and <= 459:
                case >= 461 and <= 464:
                case 467:
                case 470:
                case 472:
                case >= 476 and <= 479:
                case >= 481 and <= 482:
                case 485:
                case 489:
                case >= 492 and <= 493:
                case >= 497 and <= 499:
                case 501:
                case 503:
                case 507:
                case 513:
                case 673:
                case 676:
                case 700:
                case 702:
                case 866:
                case >= 1064 and <= 1066:
                case >= 1109 and <= 1110:
                    return "3.0";
                case >= 442 and <= 445:
                    return "3.01";
                case 431:
                case >= 449 and <= 452:
                case 701:
                    return "3.05";
                case 504:
                    return "3.07";
                case 448:
                case 508:
                case >= 510 and <= 512:
                case >= 514 and <= 515:
                case >= 589 and <= 591:
                    return "3.1";
                case 505:
                case 517:
                case >= 519 and <= 524:
                case >= 529 and <= 533:
                case >= 537 and <= 553:
                case 1111:
                    return "3.2";
                case 554:
                case >= 556 and <= 560:
                case >= 566 and <= 568:
                case 1112:
                    return "3.3";
                case >= 561 and <= 565:
                case 570:
                    return "3.35";
                case >= 534 and <= 536:
                case 571:
                case >= 573 and <= 578:
                case >= 592 and <= 610:
                case >= 624 and <= 625:
                case 809:
                case 1113:
                    return "3.4";
                case 611:
                case 921:
                    return "3.45";
                case >= 580 and <= 588:
                case 617:
                case 627:
                case >= 637 and <= 638:
                case 1114:
                    return "3.5";
                case 656:
                    return "3.55";
                case 633:
                    return "3.56";
                case >= 612 and <= 614:
                case 616:
                case >= 620 and <= 623:
                case 626:
                case >= 628 and <= 629:
                case >= 634 and <= 635:
                case >= 639 and <= 641:
                case >= 647 and <= 655:
                case >= 657 and <= 665:
                case 667:
                case >= 670 and <= 671:
                case 674:
                case >= 677 and <= 698:
                case 703:
                case >= 705 and <= 711:
                case >= 713 and <= 720:
                case >= 722 and <= 724:
                case >= 726 and <= 727:
                case >= 738 and <= 740:
                case 744:
                case >= 756 and <= 757:
                case >= 759 and <= 760:
                case >= 807 and <= 808:
                case 812:
                case 868:
                case >= 1142 and <= 1146:
                    return "4.0";
                case 636:
                    return "4.01";
                case 712:
                    return "4.05";
                case 403:
                case 725:
                case >= 730 and <= 731:
                case >= 734 and <= 737:
                    return "4.1";
                case 733:
                    return "4.11";
                case 729:
                    return "4.15";
                case >= 741 and <= 743:
                case 746:
                case >= 748 and <= 755:
                case 758:
                case 764:
                case 781:
                    return "4.2";
                case 732:
                    return "4.25";
                case >= 768 and <= 769:
                case 776:
                case >= 778 and <= 779:
                case >= 786 and <= 787:
                    return "4.3";
                case 777:
                    return "4.31";
                case >= 770 and <= 775:
                case 780:
                case >= 782 and <= 785:
                    return "4.35";
                case >= 761 and <= 763:
                case 790:
                    return "4.36";
                case >= 788 and <= 789:
                case 792:
                case 794:
                case >= 797 and <= 805:
                case >= 810 and <= 811:
                case 899:
                case 1098:
                    return "4.4";
                case 795:
                    return "4.45";
                case 793:
                case 796:
                case >= 824 and <= 829:
                    return "4.5";
                case 791:
                    return "4.55";
                case 806:
                case 830:
                case 834:
                    return "4.56";
                case >= 813 and <= 823:
                case >= 836 and <= 838:
                case >= 840 and <= 864:
                case >= 869 and <= 877:
                case >= 880 and <= 881:
                case 912:
                    return "5.0";
                case 878:
                case 965:
                    return "5.01";
                case 879:
                    return "5.05";
                case 882:
                case >= 884 and <= 885:
                case >= 888 and <= 896:
                    return "5.1";
                case >= 886 and <= 887:
                    return "5.11";
                case >= 897 and <= 898:
                case 900:
                case >= 902 and <= 909:
                case 914:
                case >= 918 and <= 919:
                case 929:
                    return "5.2";
                case 901:
                    return "5.21";
                case 911:
                case 913:
                case 915:
                case 920:
                    return "5.25";
                case >= 916 and <= 917:
                case >= 922 and <= 923:
                case >= 925 and <= 926:
                case 928:
                case >= 931 and <= 932:
                case 939:
                    return "5.3";
                case 964:
                    return "5.35";
                case 924:
                case >= 933 and <= 937:
                case >= 942 and <= 949:
                case >= 954 and <= 955:
                case 967:
                    return "5.4";
                case 938:
                case >= 950 and <= 951:
                case 966:
                case 991:
                    return "5.5";
                case 975:
                case 977:
                    return "5.55";
                case 952:
                case >= 956 and <= 963:
                case >= 969 and <= 971:
                case >= 973 and <= 974:
                case 976:
                case >= 978 and <= 987:
                case 990:
                case >= 992 and <= 993:
                case >= 995 and <= 999:
                case >= 1001 and <= 1002:
                case 1004:
                case 1006:
                case 1008:
                case >= 1010 and <= 1031:
                case 1055:
                    return "6.0";
                case 994:
                case 1000:
                case 1003:
                case 1005:
                case 1007:
                case 1009:
                    return "6.05";
                case >= 1050 and <= 1051:
                case 1054:
                case >= 1056 and <= 1057:
                case 1061:
                    return "6.1";
                case 968:
                    return "6.11";
                case >= 1070 and <= 1072:
                case >= 1077 and <= 1079:
                case >= 1081 and <= 1089:
                case >= 1091 and <= 1093:
                    return "6.2";
                case 1069:
                case 1073:
                case >= 1075 and <= 1076:
                    return "6.25";
                case 1094:
                    return "6.28";
                case >= 1095 and <= 1097:
                case >= 1116 and <= 1120:
                case >= 1123 and <= 1125:
                    return "6.3";
                case 1122:
                    return "6.31";
                case >= 1099 and <= 1108:
                case 1115:
                    return "6.35";
                case 1126:
                case >= 1140 and <= 1141:
                case >= 1147 and <= 1154:
                case >= 1156 and <= 1163:
                    return "6.4";
                case 1137:
                case 1155:
                    return "6.45";
                case 509:
                    return "6.5";
                default:
                    return "9999999.99";
            }
        }
    }
}

