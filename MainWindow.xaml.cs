using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ILNumerics;
using MSTClass_ABlockJS;

namespace BlockJSAlg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {

        double[] R_sig = null;
        public MainWindow()
        {
            InitializeComponent();

            // Step 8 : Optionally Remove 3 / 5 points spectral DC → R_sig
            R_sig = new double[] {1242468520996.05,
                1269816048064.46,
                1302207662770.71,
                1359907246667.25,
                1446412086495.54 ,
                1397227946753.68 ,
                1256702306254.11,
                1704586708438.86,
                1277543316500.51,
                1326710071928.44,
                1273804211465.86,
                1195553367456.82,
                1126466830293.19,
                1164208008033.12,
                1276137237978.93,
                1349674131811.46,
                1360721897699.97,
                1516434574441.50,
                1292296632657.95,
                1251597594195.73,
                1183050848414.20,
                1134297966574.24,
                1104356412041.27,
                1090862081385.96,
                1122423328780.03,
                1221198315273.88,
                1352157062477.46,
                1486157460314.65,
                1570426046864.24,
                1538967199935.06,
                1456139065074.32,
                1397454355298.06,
                1344979195985.73,
                1380766033913.80,
                1473313356961.07,
                1298019319659.95,
                1201248888384.67,
                2006885583500.30,
                2885359805002.96,
                2245227607541.88,
                1536151139780.84,
                1442611903048.86,
                1778938984834.44,
                1781999464387.46,
                1646356813637.55,
                1737349030669.75,
                1702933143456.28,
                1742238974606.79,
                1783121720324.65,
                1910436872763.09,
                2087885285019.32,
                2140740364468.66,
                2244666437595.19,
                2239689425542.40,
                1939253644379.86,
                1664983275279.66,
                1447967769452.88,
                1594181727893.75,
                1867427853276.53,
                1805551749922.41,
                1759907175048.08,
                1753842616217.51,
                1792747299210.17,
                1747683518694.68,
                1672641535554.80,
                1634649017407.70,
                1618420029637.35,
                1597023079542.79,
                1594520776437.69,
                1631811330483.36,
                1689312095843.24,
                1751085019264.61,
                1780681554559.10,
                1738193741373.79,
                1657393577620.64,
                1578952492481.44,
                1523613142966.58,
                1547157193017.38,
                1627831627381.94,
                1649229808535.66,
                1703128948120.28,
                2055287874644.94,
                2068434483949.90,
                2434560660250.00,
                1667071633094.56,
                2131546245122.76,
                2903934278291.29,
                1373574399074.90,
                2874836079720.74,
                2405385919573.87,
                2199472397694.20,
                2058378281857.00,
                2083763311316.80,
                2175742823337.57,
                2340507117438.76,
                2621147580945.58,
                2873357959265.74,
                2911713378977.78,
                2813176076018.61,
                2698063647002.49,
                2605797799169.67,
                2591346051182.35,
                2679180381183.55,
                2693799650327.71 ,
                2556427408253.62 ,
                2864241514405.84 ,
                4045435518595.92 ,
                1386608653624.56 ,
                3861905624471.82 ,
                3166915680843.29 ,
                2937281518241.18 ,
                2819618515966.75 ,
                2904215187122.96 ,
                2932557383823.57 ,
                2913691050160.13 ,
                3145970874998.75 ,
                3331007893849.28 ,
                2915107269739.33 ,
                3643396334637.06 ,
                3062804711925.62 ,
                3388983807286.83 ,
                3233945819043.53 ,
                3036942084090.45 ,
                3019557851616.32 ,
                3110023459978.49 ,
                3001783505542.92 ,
                2721352145233.32 ,
                3550816108301.61 ,
                2783269918755.02 ,
                3185972369878.16 ,
                5101222685685.30 ,
                4034128307616.39 ,
                1916997380379.35 ,
                4853386100014.88 ,
                1857741358332.32 ,
                2171671181387.96 ,
                2132476486448.01 ,
                2875626808047.88 ,
                3768616419887.49 ,
                5525195313350.93 ,
                6912813462454.87 ,
                5198963735608.29 ,
                2415799667753.17 ,
                4364796944806.22 ,
                3831330538984.24 ,
                3599195098378.96 ,
                2808542408327.45 ,
                3070816278218.41 ,
                3135290090137.12 ,
                4125395646351.56 ,
                5611736245598.96 ,
                6423938123585.55 ,
                6839747834295.37 ,
                6726378137573.73 ,
                6117723394613.67 ,
                6236674745162.53 ,
                4375960858804.30 ,
                3398958961036.93 ,
                2614143161853.23 ,
                1402177846945.47 ,
                936759704179.109 ,
                6567701544345.27 ,
                13001599858863.7 ,
                14427276917663.1 ,
                9306883751424.36 ,
                31830756787309.7 ,
                12835729309872.0 ,
                2131186414045.19 ,
                2848598603785.04 ,
                2270661245254.69 ,
                2896369405088.26 ,
                4399610254792.06 ,
                4872730739969.86 ,
                14035713934799.8 ,
                8207436270699.01 ,
                10728174272091.6 ,
                10565784928762.0 ,
                8599517693029.09 ,
                5338991374533.33 ,
                2009790771336.95 ,
                1348587006386.86 ,
                2505460206284.74 ,
                4243204109839.80 ,
                15815598957720.3 ,
                12609778626661.1 ,
                18050332570684.8 ,
                18466171196306.2 ,
                24512815539754.8 ,
                7634271358265.62 ,
                4803874856577.63 ,
                2549064224251.10 ,
                2163683972765.67 ,
                3982952637819.53 ,
                4938109013257.81 ,
                14888427567992.2 ,
                16693634189895.9 ,
                16857764905251.4 ,
                23977647377846.7 ,
                8146105719733.35 ,
                7712720295037.65 ,
                6457506166172.76 ,
                2922837368585.43 ,
                1166834285565.65 ,
                3564083528233.14 ,
                9515688373474.50 ,
                28844392429581.5 ,
                26677665750883.0 ,
                38326731995013.3 ,
                16213844557543.1 ,
                29890006417378.9 ,
                25282690106822.3 ,
                31138252930657.0 ,
                5049888532337.24 ,
                7470897418188.69 ,
                9276430494431.56 ,
                5573756633574.88 ,
                59369261189211.2 ,
                71541295489798.0 ,
                81662814381612.3 ,
                35923383047974.8 ,
                24406305914288.5 ,
                71009942105895.4 ,
                50224997011579.5 ,
                28394409022331.1 ,
                27324595575363.5 ,
                37300960087823.3 ,
                35775128653188.7 ,
                75180350137911.3 ,
                70843419388543.1 ,
                153153033009635  ,
                91516702877517.8 ,
                214500883802626  ,
                286954016429900  ,
                76156681937345.9 ,
                1.10331112043396e+15,
                52998576608734.3 ,
                374063659286789  ,
                160629299806627  ,
                682101579962977  ,
                899816831034760 ,
                161357901136806 ,
                39680888451483.8,
                455121937408809 ,
                302923386970406 ,
                371784213506550 ,
                86077449726686.2,
                248315569276660 ,
                65569222590695.7,
                27061550380288.6,
                666867945841197 ,
                432680984788820 ,
                6.28083176100516e+15,
                5.67745438718748e+15,
                1.41822768291587e+16,
                9.45502437444441e+15,
                4.72777503268516e+15,
                2.49579283559317e+15,
                263822234197736     ,
                527087235752355     ,
                790383065424764     ,
                24556642665378.2    ,
                670928601447870     ,
                862470977889818     ,
                1.32660107396050e+15,
                1.84193329636306e+15,
                2.20203071710260e+15,
                2.42811707576953e+15,
                105582007743395     ,
                2.85537142726213e+15,
                568948829504876     ,
                1.75989342813870e+15,
                310277457905704     ,
                982609850152281     ,
                4275242617724.13    ,
                931308550996285     ,
                1.01196031223354e+15,
                52893397524101.2    ,
                267222359270746     ,
                255701250640546     ,
                301790628629.000    ,
                62709004996113.4    ,
                12343692150604.0    ,
                26454068969492.4    ,
                2511462650066.43    ,
                4023993395932.92    ,
                157094254976556,
                34742938995468.6,
                129172502604666 ,
                21882876856772.3,
                90564897189637.2,
                64823871476721.5,
                9294213431608.81,
                142070401901458 ,
                3896042455703.13,
                43021445875496.6,
                6428254423759.14,
                4185567056479.76,
                31476457795075.0,
                42048324634855.0,
                7177768655277.24,
                20590194320616.1,
                24738302838831.9,
                15971827487898.2,
                3251249221202.87,
                9600409240351.82,
                5829811325839.42,
                10365528727856.0,
                995663834971.836,
                19218215385657.2,
                35202346527612.3,
                4027596928942.55,
                15541534543616.3,
                5705570664353.34,
                6186128587607.05,
                2067158559266.20,
                17551759715878.8,
                2425930223705.11,
                6913067675008.55,
                8472068823659.35,
                6232983834119.09,
                3255351501576.21,
                2365664367715.25,
                7495727365741.36,
                7522732314035.63,
                2654773754180.51,
                2453234400263.58,
                3537671332490.33,
                3842290912813.06,
                3139730035391.13,
                4871418590227.70,
                8307493085618.88,
                309180868043.969,
                5135947460551.98,
                8879837252340.04 ,
                1856825492785.91 ,
                2145973488109.53 ,
                2466085600107.73 ,
                2113917145055.18 ,
                1861720973286.66 ,
                1927019923045.34 ,
                2184194203201.30 ,
                2582372872243.74 ,
                3159136351492.52 ,
                2144467708818.75 ,
                2858957809153.86 ,
                3250760546336.65 ,
                4286676250125.63 ,
                854636530474.472 ,
                4704310067115.57 ,
                2916398457757.08 ,
                840149560632.895 ,
                6286710942520.96 ,
                1508083431391.73 ,
                2549164121321.19 ,
                2833509018126.39 ,
                2350228288173.70 ,
                1725238227879.43 ,
                2228442920038.78 ,
                3105973331695.47 ,
                2905075425416.88 ,
                2196668814908.79 ,
                2506749658691.56 ,
                2827282544354.46 ,
                2196438557228.75 ,
                1449219164647.73 ,
                4528249193999.28 ,
                8018803214548.75 ,
                6102478946089.81 ,
                2132312133590.94 ,
                3948618186548.71 ,
                3552856862823.49 ,
                3672662323764.68 ,
                2741595421882.13 ,
                2283862720042.95 ,
                1962777089374.11 ,
                1502903771551.75 ,
                1077504903899.91 ,
                1090888570663.89 ,
                1003354765685.00 ,
                950708539248.720 ,
                1248845514878.02 ,
                1314802358228.73 ,
                1390319306952.55 ,
                1466872975683.98 ,
                1559911672972.51 ,
                1734665435546.22 ,
                1812397985110.15 ,
                1924491645775.35 ,
                1973410807503.12 ,
                1958954634944.34 ,
                1895827432935.56 ,
                1735142517354.90 ,
                1723743545366.65 ,
                1606277930289.60 ,
                1632792443506.76 ,
                1621558244168.46 ,
                1641929894105.63 ,
                1679168167308.54 ,
                1721928356481.46 ,
                1758752048868.48 ,
                1772901316187.68 ,
                1745013748846.43 ,
                1685761668169.52 ,
                1619996880091.05 ,
                1545882657138.80 ,
                1449993851268.48 ,
                1380895351048.42 ,
                1314320552013.00 ,
                1293612404902.53 ,
                1352772269719.26 ,
                1484411983089.23 ,
                1635174213694.70 ,
                1398429258376.99 ,
                2026898017037.59 ,
                1420223381511.96 ,
                1476076719184.95 ,
                1399099623750.10 ,
                1300016505873.43 ,
                1188857296446.80 ,
                1107476511987.90 ,
                1032227639768.49 ,
                1138449796144.99 ,
                1496436598292.20 ,
                1254542188329.42 ,
                549844127583.094 ,
                3107204335461.74 ,
                647469468312.212 ,
                1156854256314.50 ,
                1231751072577.49 ,
                1225860423103.60 ,
                1097414641229.10,
                1268515663103.11,
                1201280997072.14,
                1234459842920.05,
                1207394034905.63,
                1180837558918.44,
                1139089933780.46,
                1111041072179.29,
                1091074296654.97,
                1001545273675.52,
                938709003342.479,
                1101287601662.29,
                1283595435990.55,
                1154739741857.63,
                920010348248.119,
                898345484791.194,
                974022330812.669,
                968562330683.034,
                923057584358.584,
                894673929526.864,
                870412392514.680,
                838313546869.550,
                813370570983.347,
                808887429906.268,
                817705549800.511,
                831677875104.987,
                837499848599.537,
                821392793994.417,
                791771415922.527,
                761036091896.768,
                741828625690.953,
                746879836532.203,
                772024065949.668,
                808525548456.728,
                846460936837.975,
                876701446180.906,
                899037708428.073,
                913908688286.150,
                932852699375.580,
                964846078587.336,
                1000864695050.27,
                1034116996671.41,
                1035738551498.11,
                979894915913.900,
                888458635441.749,
                785712337554.863,
                717647731862.242,
                729790470318.841,
                795425911760.958,
                877421690084.039,
                929725981144.909,
                904409778611.161,
                824213697573.086,
                726555226912.631,
                646034973616.361,
                619290015054.859,
                634546702421.185,
                668297086437.043,
                699814831526.587,
                707938889184.300,
                701716075207.553,
                693662368037.511,
                700857561832.346,
                754680142510.003,
                845310726918.758,
                898506973660.797,
                902668712260.979,
                1081731667761.16,
                911562592469.356,
                927083714755.172,
                934382708919.594,
                988549626346.435,
                1068872887854.05,
                1162451621097.10,
                1244830438420.55,
                1285313589406.15,
                1293382803743.41,
                1289151745558.29,
                1276159292353.43,
                1260503914892.62,
                1247692154124.12,
                1237711220080.46,
 };

            for (int i = 0; i < R_sig.Length; i++)
                lstInput.Items.Add(R_sig[i]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            
            //Algorithm Step 9. Initialize coefficients with modified 〖Sym〗_8 coefficients for a 5  level filtering → 〖nlvl〗_5
            String WavelettName = "Modified Sym 8"; int nlvl = 5;
          

            //Algorithm Step 10. Calculate the Orthogonal wavelet filter set.
            double[] OrthloFit = null;
            if (WavelettName == "Modified Sym 8")
            {
                OrthloFit = new double[16] { 0.00133639669640, -0.00021419715012, -0.01057284326418, 0.00269319437688, 0.03474523295559, -0.01924676063167, -0.03673125438038, 0.25769933518654, 0.54955331526901, 0.34037267359439, -0.04332680770282, -0.10132432764282, 0.00537930587524, 0.02241181152181, -0.00038334544811, -0.00239172925575 };
                double sumorthloFit = OrthloFit.Sum();
                for (int i = 0; i < OrthloFit.Length; i++)
                    OrthloFit[i] = OrthloFit[i] / sumorthloFit;
            }

            //Algorithm Step 10.1. Calculate Decomposition Low - pass, high - pass filter values → LoD,HiD
            //Algorithm Step 10.2. Calculate the Reconstruction Low-pass, high - pass filter values → LoR,HiR
            double[] LoD = new double[OrthloFit.Length];
            double[] HiD = new double[OrthloFit.Length];
            double[] LoR = new double[OrthloFit.Length];
            double[] HiR = new double[OrthloFit.Length];
            for (int i = 0; i < OrthloFit.Length; i++)
                LoR[i] = Math.Sqrt(2) * OrthloFit[i];

            for (int i = 0; i < LoR.Length; i++)
            {
                Double y = Convert.ToDouble(LoR[(LoR.Length - 1) - i]);
                if (i % 2 == 0) HiR[i] = y;
                else HiR[i] = -y;
            }

            for (int i = 0; i < HiR.Length; i++)
                HiD[i] = Convert.ToDouble(HiR[(HiR.Length - 1) - i]);
            for (int i = 0; i < LoR.Length; i++)
                LoD[i] = Convert.ToDouble(LoR[(LoR.Length - 1) - i]);

            //Algorithm Step 11.Calculate using ABlockJS taking Segment input:total Process
            Double[] SegmentOutPut = MultiSignalWaveletDecomposition_ABlockJS(R_sig, nlvl, LoD, HiD, LoR, HiR);

            for (int i = 0; i < SegmentOutPut.Length; i++)
                lstOutput.Items.Add(SegmentOutPut[i]);
        }
        private static Double[] MultiSignalWaveletDecomposition_ABlockJS(double[] R_sig, int nlvl, double[] LoD, double[] HiD, double[] LoR, double[] HiR)
        {


            //Algorithm Step 11.1 Decompose R_sig using Multi signal Wavelet Decomposition 
            int nfft = R_sig.Length;


            //Algorithm Step 11.1.1. Extend, Decompose and Extract → xDec
            double[] WD = new double[nfft];
            double[] xDec_CA = new double[nfft];
            double[][] xDec_CD = new double[nfft][];
            Int32[] SHE = new Int32[nlvl + 2];
            SHE[SHE.Length - 1] = nfft;

            //Algorithm Step 11.1.1.1. Initialize Approximation Coefficients → xDec.Ca
            //Algorithm Step 11.1.1.2. Initialize Detailed Coefficients for nlvl levels → xDec.Cd
            mdwtdec(R_sig, nlvl, LoD, HiD, LoR, HiR, out xDec_CA, out xDec_CD, SHE);
            SHE[0] = xDec_CA.Length;

            //Algorithm Step 11.2. Calculate Normalization Factor → norf

            double lambda = 4.50524;
            double L = Math.Max(Math.Floor(Math.Log(R_sig.Length)), 1);
            ILArray<double> blockjsd1 = xDec_CD[0];
            double norf  = (double)ILMath.divide(1, -(ILMath.multiply(ILMath.sqrt((double)2), -0.476936276204470)));//-0.476936276204470=erfcinv(2*0.75)
            double vscale = (double)ILMath.multiply(norf, ILMath.median(ILMath.abs(blockjsd1)));



            

            //Algorithm Step 11.5.Repeat calculation of ABlockJS-threshold for at all nlvl levels
            for (int lev = nlvl - 1; lev >= 0; lev--)
            {
                //Algorithm Step 11.5.1 Using xDec.Cd at the current level and vScale → xDecL

                xDec_CD[lev] = MyblockJs(xDec_CD[lev], lambda, L, vscale);
            }

            //Algorithm Step 11.6.3 F_o as Segment output
            double[] F_o = mdwtrec(LoR, HiR, xDec_CA, xDec_CD, nlvl, SHE);

            //return F_o as Segment output
            return F_o;

        }
        public static double[] MyblockJs(double[] xwCoef, double lambda, double L, double sigma)
        {
            
            Class1 clseABlockJS = new Class1();
            //%11.5.1.1.Extract the Wavelet coefficients using James Stein Rule→ xwCoef

            double[] temp_wcoef = xwCoef;

            int N = temp_wcoef.Length;
            
            int NumSig = 1;
            
           //% 11.5.1.2.Enlist the coefficients of current level → lstCoef
            List<double> lstCoef = new List<double>();
            lstCoef.AddRange(temp_wcoef);
            int rem = 0;
            Math.DivRem((N - 1), (int)L, out rem);
            //%11.5.1.3.Calculate L - (rem(len(lstCoef) - 1, L) + 1)→Nc
            int Nc = Convert.ToInt32(L - (rem + 1));
            //%11.5.1.4.Create a new coefficients list by selecting Nc Coefficients from head of lstCoef list and appending them to the tail → lstNewCoef
            List<double> lstNewCoef = lstCoef;
            for (int i = 0; i < Nc; i++)
                lstNewCoef.Add(temp_wcoef[i]);

            int Nnew = lstNewCoef.Count;
            //%11.5.1.5.Initialize len(lstNewCoef) / L→  nBlks
            int nBlks = Convert.ToInt32(Nnew / L);

            //%11.5.1.6.Using lstNewCoef ,nBlks,L Estimate all nBlks blocks → B Estimate all nBlks block Energy→ BE

            double[][] B = null;
            double[] BE = null;
            //% return blocks and block energy
            clseABlockJS.bufferData(lstNewCoef, L, nBlks, out B, out BE);
            double penalty = lambda * L * Math.Pow(sigma, 2);
            //%11.5.1.7.Calculate Threshold Coefficients for total B → wthrcoef

           double[][] wthrcoef = new double[nBlks][];
            for (int nb = 0; nb < nBlks; nb++)
            {
                wthrcoef[nb] = new double[(Int32)L];
                double JSfactor = Math.Max(0, (1 - (penalty / BE[nb])));
                double[] ArrJSFactor = new double[(Int32)L];
                for (int i = 0; i < (Int32)L; i++)
                    ArrJSFactor[i] = JSfactor;
                wthrcoef[nb] = ILMath.multiplyElem(JSfactor, B[nb]).ToArray();
                //ILArray<double> jsfactor = ILMath.max(0,(ilma))
            }

            //reshape wthrcoef to Nnew
            //%11.5.1.8.Enlist all the Coefficients in wthrcoef→ wthrcoeflst
            double[] wthrcoeflst = new double[Nnew];
            int k = 0;
            for (int i = 0; i < nBlks; i++)
                for (int j = 0; j < (Int32)L; j++)
                    wthrcoeflst[k++] = wthrcoef[i][j];

            //%11.5.1.9.Extract  len(xDecL) from the head of  wthrcoeflst→xwCoef
            for (int i = 0; i < N; i++)
                xwCoef[i] = wthrcoeflst[i];

            //%11.5.1.10.Replace xDec.Cd with current level xwCoef

            return xwCoef;
        }
        private static void mdwtdec(double[] x, int level, ILArray<double> LoD, ILArray<double> HiD, ILArray<double> LoR, ILArray<double> HiR, out double[] xDec_CA, out double[][] xDec_CD, int[] SHE)
        {
            Class1 clseABlockJS = new Class1();
            //Algorithm Step 11.1.2 Store the symmetric half-point extension → SHE=sx
            int First = 2; xDec_CD = new double[level][]; xDec_CA = new double[x.Length];
            for (int j = level + 1; j > 1; j--)
            {
                int lf = LoD.Length;
                int lx = x.Length;
                int dcol = lf - 1;
                int lenEXT = lf - 1;
                int lenKEPT = lx + lf - 1;
                List<int> idxCOL = new List<int>();
                int Checking = 1;
                for (int i = 0; i < Checking; i++)
                {
                    if (i == 0)
                    {
                        idxCOL.Add(First + dcol); Checking++;
                    }
                    else
                    {
                        int d = idxCOL[i - 1] + 2;
                        if (d <= (lenKEPT + dcol))
                        {
                            idxCOL.Add(d);
                            Checking++;
                        }
                        else Checking = 0;
                    }

                }
                int[] I = new int[lenKEPT + dcol];
                bool zeroaccept = false; bool nfftAccept = false;
                for (int i = 0; i < I.Length; i++)
                {
                    if (i == 0) I[i] = lenEXT;
                    else
                    {
                        if (!zeroaccept)
                        {
                            if ((I[i - 1] - 1) > 0)
                                I[i] = I[i - 1] - 1;
                            else if ((I[i - 1] - 1) == 0)
                            {
                                I[i] = I[i - 1];
                                zeroaccept = true;
                            }
                        }
                        else if (!nfftAccept && zeroaccept)
                        {
                            if ((I[i - 1] + 1) < lx + 1)
                                I[i] = I[i - 1] + 1;
                            else if ((I[i - 1] + 1) == lx + 1)
                            {
                                I[i] = I[i - 1];
                                nfftAccept = true;
                            }
                        }
                        else
                            I[i] = I[i - 1] - 1;
                    }

                }

                double[] y = new double[I.Length];
                for (int i = 0; i < y.Length; i++)
                {
                    y[i] = x[I[i] - 1];
                }
                //Algorithm Step 11.1.3. Do the 2D convolution of SHE with LoD → xDec.Ca
                
                double[] conva = clseABlockJS.Convlution2D(y, LoD);
                double[] a = new double[idxCOL.Count];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = conva[idxCOL[i] - 1];
                }
                //Algorithm Step 11.1.4. Do the 2D convolution of SHE with HiD → xDec.Cd
                double[] Convd = clseABlockJS.Convlution2D(y, HiD);
                double[] dd = new double[idxCOL.Count];

                for (int i = 0; i < dd.Length; i++)
                {
                    dd[i] = Convd[idxCOL[i] - 1];
                }

                x = a;
                xDec_CA = new double[x.Length];
                xDec_CA = a;
                xDec_CD[level + 1 - j] = new Double[dd.Length];
                for (int k = 0; k < dd.Length; k++)
                    xDec_CD[level + 1 - j][k] = dd[k];


                SHE[j - 1] = dd.Length;

            }

        }

        private static double[] mdwtrec(ILArray<double> LoR, ILArray<double> HiR, double[] CA, double[][] CD, int level, int[] sx)
        {
            Class1 clseABlockJS = new Class1();
            int levMin = 0;
            int levMax = level;
            double[] x = CA;
            Double[] F_o = null;
            //Algorithm Step 11.6 Multi signal Wavelet Reconstruction at all levels of xDec.Ca and Repeat the following for all nlvl levels from max-level to min - level
            for (int j = levMax; j > levMin; j--)
            {

                int p1 = levMax + 2 - j;
                int lenkept = sx[p1];
                int sx2 = 2 * x.Length;
                double[] y1 = new double[sx2 - 1];
                int k = 0;
                for (int i = 0; i < y1.Length; i++)
                {
                    if (i % 2 == 0) { y1[i] = x[k]; k++; }
                    else y1[i] = 0;
                }
                //Algorithm Step 11.6.1. Up - Sample, 2D convolution using xDec.Ca and LoR → lxDec
                double[] lxDec = clseABlockJS.Convlution2D(y1, LoR);
                int sy = lxDec.Length;
                if (lenkept > sy) lenkept = sy;
                double d = (sy - lenkept) / 2;
                int first = 1 + Convert.ToInt32(Math.Floor(d));
                int Last = sy - Convert.ToInt32(Math.Ceiling(d));

                double[] SumY1 = new double[(Last - first) + 1];

                int m = first - 1;
                for (int i = 0; i < SumY1.Length; i++)
                {
                    SumY1[i] = lxDec[m]; m++;
                }


                sx2 = 2 * CD[j - 1].Length;
                double[] y2 = new double[sx2 - 1];
                k = 0;
                for (int i = 0; i < y2.Length; i++)
                {
                    if (i % 2 == 0) { y2[i] = CD[j - 1][k]; k++; }
                    else y2[i] = 0;
                }
                //Algorithm Step 11.6.2. Up-Sample, 2D convolution using xDec.Ca and HiR → hxDec
                double[] hxDec = clseABlockJS.Convlution2D(y2, HiR);
                sy = hxDec.Length;
                if (lenkept > sy) lenkept = sy;
                d = (sy - lenkept) / 2;
                first = 1 + Convert.ToInt32(Math.Floor(d));
                Last = sy - Convert.ToInt32(Math.Ceiling(d));

                double[] SumY2 = new double[(Last - first) + 1];

                m = first - 1;
                for (int i = 0; i < SumY2.Length; i++)
                {
                    SumY2[i] = hxDec[m]; m++;
                }

                //Algorithm Step 11.6.3. Add lxDec and hxDec → F_o as Segment output
                F_o = new double[lenkept];

                for (int i = 0; i < F_o.Length; i++)
                    F_o[i] = SumY1[i] + SumY2[i];


                x = F_o;

            }
            //return Segment output F_o
            return F_o;
        }

        

       
        public static double[] postmedCauchy(double[] data, double weight, int maxiter)
        {
            Class1 clseABlockJS = new Class1();
            double[] muhat = new double[data.Length];
            int M = data.Length;
            int N = 1;
            int[] muhatlen = new int[M];

            double[] Weight = new double[M];
            for (int i = 0; i < M; i++)
                Weight[i] = weight;
            double[] magdata = ILMath.abs((ILArray<double>)data).ToArray();

            double[] magdatatmp = new double[M];
            for (int i = 0; i < M; i++)
                magdatatmp[i] = magdata[i];

            double[] idx = new double[M];
            for (int i = 0; i < M; i++)
                if (magdata[i] < 20) idx[i] = 1;
                else idx[i] = 0;
            for (int i = 0; i < M; i++)
                if (idx[i] == 0) magdata[i] = double.NaN;
            double lo = 0; List<double> delta = new List<double>();
            double[] zeromd = new double[magdata.Length];
            clseABlockJS.intervalSolve(zeromd, lo, magdata.Max(), maxiter, magdata, Weight, out muhat, out delta);
            for (int i = 0; i < M; i++)
                if (idx[i] == 0)
                    muhat[i] = (magdatatmp[i]) - (2 / magdatatmp[i]);
            for (int i = 0; i < M; i++)
                if (muhat[i] < 1e-7)
                    muhat[i] = 0;
            muhat = ILMath.multiplyElem(ILMath.sign((ILArray<double>)data), muhat).ToArray();
            double[] hugeMuInds = new double[M];
            for (int i = 0; i < M; i++)
                if (Math.Abs(muhat[i]) > Math.Abs(data[i]))
                    hugeMuInds[i] = 1;
                else
                    hugeMuInds[i] = 0;
            for (int i = 0; i < M; i++)
                if (hugeMuInds[i] == 1)
                    muhat[i] = data[i];


            return muhat;
        }
    }
}
