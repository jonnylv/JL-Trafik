using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        //CK prov

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions; 



        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 70; 

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag); 


            if(buttonTag == correctAnswer)
            {

                score++; 
            }

            if (questionNumber == totalQuestions)

            {
                //Antal rätt i procentform

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show
                    (

                    "Provet är avslutat" + Environment.NewLine + 
                    "Du har svarat" + " " + score + " " + "frågor korrekt" + Environment.NewLine + 
                    "Din totala procent är " + percentage + "%" + Environment.NewLine +
                    "Tryck igen för att fortsätta"

                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber); 


            }


            questionNumber++;
            askQuestion(questionNumber);


        }

        private void askQuestion(int qnum)
        {

            switch(qnum)

            {

                case 1:
                    



                     lblQuestion.Text = "Vilket påstående om körfält är riktig? ";

                    button1.Text = "Vägrenen är ett körfält";
                    button2.Text = "Ett körfält behöver inte anges med vägmarkering. ";
                    button3.Text = "Ett körfält måste alltid anges med markering. ";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;


                    break;


                case 2:

                   

                    lblQuestion.Text = "Du har körkort med prövotid. Vad gäller? ";

                    button1.Text = "Jag måste göra om både kunskapsprovet och körprovet om körkortet återkallas under periodtiden.";
                    button2.Text = "Jag behöver enbart göra om körprovet om körkortet återkallas under periodtiden";
                    button3.Text = "Körkortet återkallas i två månader om man bötfälls för felparkering.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 1;

                    break;


                case 3:
                    

                    lblQuestion.Text = "Vad innebär begreppet lätt lastbil?";

                    button1.Text = "Lastbil som har totalvikt på högst 3.5 ton";
                    button2.Text = "Lastbil som har en maxlastvikt på högst 3.5 ton ";
                    button3.Text = "Lastbil som har en bruttovit på högst 3.5 ton ";
                    button4.Text = "Lastbil som har en tjänstevikt på högst 3.5 ton";

                    correctAnswer = 1;

                    break;


                case 4:
                   

                    lblQuestion.Text = "Vilket fordon får du köra med behörighet B?";

                    button1.Text = "Personbil med tillkopplad tungt släpfordon ";
                    button2.Text = "Buss godkänd för 10 passagerare ";
                    button3.Text = "Motorcykel med sidovagn";
                    button4.Text = "Lastbil med totalvikt på 3.1 ton";

                    correctAnswer = 4;

                    break;

                case 5:
                  

                    lblQuestion.Text = "Vilken avgas saknar lukt och smak och påverkar hjärt och kärlsystem?";

                    button1.Text = "Kolmonoxid";
                    button2.Text = "Koldioxid";
                    button3.Text = "Kolväten";
                    button4.Text = "Kväveoxid";

                    correctAnswer = 1;

                    break;

                case 6:
                    

                    lblQuestion.Text = "När är risken störst att du drabbas av kolmonoxid förgiftning?";

                    button1.Text = "När jag kör med fönstren öppna i hög hastighet.";
                    button2.Text = "När jag kör motorn på tomgång i ett garage med dålig ventilation.";
                    button3.Text = "När jag kör sakta i en trafikkö inom tätbebyggt område.";
                    button4.Text = "När jag kör med fönstren öppna i låg hastighet.";

                    correctAnswer = 2;

                    break;


                case 7:
                  

                    lblQuestion.Text = "Du kör en bil och har lastat en cykel i bagageutrymmet. Hur ska du göra för att undvika att få avgaser in i bilen?";

                    button1.Text = "Sätt på luftkonditionering och stäng fönstrerna.";
                    button2.Text = "Stäng av fläkten och veva ner fönstrerna en bit.";
                    button3.Text = "Stäng av luftkonditionering och stäng fönstrerna.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 1;

                    break;

                case 8:
                  

                    lblQuestion.Text = "Vilket ämne i avgaserna bidrar mest till att öka växthuseffekten?";

                    button1.Text = "Kolväten";
                    button2.Text = "Kolmonoxid";
                    button3.Text = "Koldioxid";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 3;

                    break;

                case 9:


                    lblQuestion.Text = "Du kör en personbil med katalysator. Vilket ämne i avgaserna minskas inte av katalysatorn?";

                    button1.Text = "Kolmonoxid (koloxid)";
                    button2.Text = "Koldioxid ";
                    button3.Text = "Kväveoxid";
                    button4.Text = "Kolväten ";

                    correctAnswer = 2;

                    break;

                case 10:


                    lblQuestion.Text = "Vilket ämne i avgaserna bidrar till försurningen i våra skogar och sjöar?";

                    button1.Text = "Kolväten";
                    button2.Text = "Kväveoxider";
                    button3.Text = "Kolmonoxid";
                    button4.Text = "Koldioxid";

                    correctAnswer = 2;

                    break;

                case 11:


                    lblQuestion.Text = "Hur kan du på bästa sätt minska utsläppen av koldioxid?";

                    button1.Text = "Genom att köra en bil med katalysator";
                    button2.Text = "Genom att köra på lågoctanig bensin";
                    button3.Text = "Genom att varmköra motorn till en tillräckligt varm temperatur före färd.";
                    button4.Text = "Genom att köra med låga varvtal.";

                    correctAnswer = 4;

                    break;

                case 12:


                    lblQuestion.Text = "Hur kan du på bästa sätt minska bränsleförbrukningen?";

                    button1.Text = "Jag försöker hela tiden köra på höga motorvarv";
                    button2.Text = "Jag släpper gasen i god tid för att undvika bromsning";
                    button3.Text = "Jag använder bilens farthållare";
                    button4.Text = "Jag använder bilens farthållareJag använder bilens farthållare";

                    correctAnswer = 2;

                    break;

                case 13:


                    lblQuestion.Text = "På vilket sätt kan du påverka bränsleförbrukningen i din bil?";

                    button1.Text = "Bränsleförbrukningen blir lägre om jag använder motorvärmare på vintern.";
                    button2.Text = "Bränsleförbrukningen blir lägre om jag kör på låga växlar.";
                    button3.Text = "Bränsleförbrukningen blir högre om bilen får regelbunden service.";
                    button4.Text = "Bränsleförbrukningen blir högre om jag har högt lufttryck i däcken.";

                    correctAnswer = 1;

                    break;

                case 14:


                    lblQuestion.Text = "Kan du spara bensin genom ditt val av växel?";

                    button1.Text = "Ja, genom att köra med så hög växel som möjligt";
                    button2.Text = "Ja, genom att köra med så låg växel som möjligt ";
                    button3.Text = "Val av växeln har ingen betydelse fِör bensinåtgången.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 1;

                    break;

                case 15:


                    lblQuestion.Text = "Vilken utrustning är du skyldig att medföra i bilen underkörning?";

                    button1.Text = "Varningstriangel";
                    button2.Text = "Bogserlina";
                    button3.Text = "Hjälpstartkablar.";
                    button4.Text = "Hjälpstartkablar.";

                    correctAnswer = 1;

                    break;

                case 16:


                    lblQuestion.Text = "Vilket alternativ beskriver bäst mogna personers egenskaper som förare?";

                    button1.Text = "De kan tillämpa gällande regler i varje trafiksituation";
                    button2.Text = "De har förståelse för andra trafikanters misstag och svårigheter.";
                    button3.Text = "De kan förkorta bromssträckan när de kör i högre hastighet.";
                    button4.Text = "De kan snabbt ta sig ur riskfyllda situationer genom att köra impulsivt.";

                    correctAnswer = 2;

                    break;

                case 17:

                    pictureBox1.Image = Properties.Resources.Fråga_17_bild;

                    lblQuestion.Text = "Vad måste du först vara beredd på i den här situationen?";

                    button1.Text = "Fordon som kommer ut från höger efter övergångsstället.";
                    button2.Text = "Gående som går ut framför bussen.";
                    button3.Text = "Gående som går ut på övergångsstället.";
                    button4.Text = "Fordon som kommer ut från vänster efter övergångstället.";

                    correctAnswer = 2;

                    break;
                    
                    

                case 18:

                    pictureBox1.Image = Properties.Resources.CK_Trafikskola_svart_blå;

                    lblQuestion.Text = "Vad är utmärkande för en förare med moget beteende?";

                    button1.Text = "Föraren har en impulsiv körstil.";
                    button2.Text = "Föraren har en offensiv körstil.";
                    button3.Text = "Föraren reagerar starkt på medtrafikanternas felbeteende.";
                    button4.Text = "Föraren har god självkännedom.";

                    correctAnswer = 4;

                    break;

                case 19:


                    lblQuestion.Text = "Varför blir äldre förare mer sällan inblandade i olyckor än unga förare?";

                    button1.Text = "De har mer erfarenhet";
                    button2.Text = "De har mer prestigetänkande";
                    button3.Text = "De kör oftare på natten";
                    button4.Text = "De kör mer offensivt";

                    correctAnswer = 1;

                    break;

                case 20:


                    lblQuestion.Text = "Hur påverkas reaktionssträckan av förarens ålder och erfarenhet?";

                    button1.Text = "En 18-årig har vanligtvis kortare reaktionssträcka än en 45-årig erfaren förare, eftersom yngre förare har bättre raktionsförmåga.";
                    button2.Text = "En 45-årig erfaren förare har vanligtvis kortare reaktionssträcka än en 18 - årig, eftersom den erfarne föraren har lärt sig att förutse faror. ";
                    button3.Text = "Reaktionssträckan påverkas inte av förarens ålder eller erfarenhet utan beror bara på hastigheten.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;

                    break;

                case 21:


                    lblQuestion.Text = "Vad menas med grupptrycket? ";

                    button1.Text = "Då du bli stressad när du ser en polis bil. ";
                    button2.Text = "Då du blir irriterad av andra trafikanter";
                    button3.Text = "Då man blir påverkad av sina kamrater i bilen att man kör på ett sätt som man normalt inte gör.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 3;

                    break;

                case 22:


                    lblQuestion.Text = "Vilket av följande alternativ är den vanligaste anledningen till singelolyckor?";

                    button1.Text = "Halkig väg";
                    button2.Text = "Kraftig regn eller snö.";
                    button3.Text = "Föraren anpassar inte körning efter trafikförhållanden";
                    button4.Text = "Slitna däck";

                    correctAnswer = 3;

                    break;

                case 23:


                    lblQuestion.Text = "Vad kännetecknar förare som kör impulsivt?";

                    button1.Text = "De kör alltid med låg hastighet";
                    button2.Text = "De kan plötsligt svänga eller byta körfält";
                    button3.Text = "De kör med för hög hastighet";
                    button4.Text = "De har alltid dålig uppmärksamhet bakåt";

                    correctAnswer = 2;

                    break;

                case 24:


                    lblQuestion.Text = "Hur påverkas körförmågan i allmänheten av stress?";

                    button1.Text = "Littet stress kan förbättra körförmågan";
                    button2.Text = "Stress påverkar inte körförmågan";
                    button3.Text = "All sorts av stress försämrar körförmågan";
                    button4.Text = "Inget av ovanstående ";

                    correctAnswer = 1;

                    break;

                case 25:


                    lblQuestion.Text = "Hur påverkas din körförmåga i allmänhet av stress?";

                    button1.Text = "Stress påverkar inte körförmågan";
                    button2.Text = "Mycket stress kan försämra körförmågan";
                    button3.Text = "Stress försämrar alltid körförmågan";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;

                    break;

                case 26:


                    lblQuestion.Text = "Vilken typ av olyckor drabbar äldre förare oftare än andra förare?";

                    button1.Text = "Omkörningsolyckor";
                    button2.Text = "Singelolyckor";
                    button3.Text = "Korsningsolyckor";
                    button4.Text = "Olyckor där föraren är alkoholpåverkad";

                    correctAnswer = 3;

                    break;

                case 27:


                    lblQuestion.Text = "Var går gränsen för rattfylleri, promillehalten mätt i blodet?";

                    button1.Text = "0,2 promille";
                    button2.Text = "0,5 promille";
                    button3.Text = "0,8 promille ";
                    button4.Text = "1,0 promille ";

                    correctAnswer = 1;

                    break;

                case 28:


                    lblQuestion.Text = "Vad är gränsen för grovt rattfylleri.";

                    button1.Text = "0,2 promille i blodet eller 0,1 mg/liter utandningsluften.";
                    button2.Text = "1,0 promille i blodet eller 0,5 mg/liter utandningsluften.";
                    button3.Text = "1,5 promille i blodet eller 0,75 mg/liter utandningsluften.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;

                    break;

                case 29:


                    lblQuestion.Text = "Hur påverkar synen om du är alkohol påverkad?";

                    button1.Text = "Synskärp minskar och synfältet blir bredare";
                    button2.Text = "Synskärp starkas och synfält blir bredare";
                    button3.Text = "Synskärp starkas och blir lättare att användas";
                    button4.Text = "Synskärp minskas och synfältet blir smalare";

                    correctAnswer = 4;

                    break;

                case 30:


                    lblQuestion.Text = "En frisk man konsumerar 40-procentig sprit. Hur många cl alkohol förbränner han på en timme?";

                    button1.Text = "1 cl";
                    button2.Text = "2 cl";
                    button3.Text = "3 cl";
                    button4.Text = "4 cl";

                    correctAnswer = 2;

                    break;

                case 31:


                    lblQuestion.Text = "En frisk man (70 kg) konsumerar 25 cl 40-procentig sprit. Hur lång tid dröjer det innan kroppen förbränner innehållet.";

                    button1.Text = "8 timmar";
                    button2.Text = "10 timmar";
                    button3.Text = "14 timmar";
                    button4.Text = "14 timmar";

                    correctAnswer = 3;

                    break;

                case 32:


                    lblQuestion.Text = "Kan man göra någonting för att påskynda förbränningen av alkoholen i kroppen?";

                    button1.Text = "Ja, man kan sova längre.";
                    button2.Text = "Ja man kan bada bastu";
                    button3.Text = "Ja man kan ta en lång promenad";
                    button4.Text = "Nej, man kan inte öka förbränningen";

                    correctAnswer = 4;

                    break;

                case 33:


                    lblQuestion.Text = "Hur visar föraren bästa omdömet dagen efter att han har druckit en större mängd alkohol?";

                    button1.Text = "Då föraren börjar med att motionerar och sedan badar i vatten som skyndar på alkoholförbränningen.";
                    button2.Text = "Då föraren håller noga koll på hur mycket han dricker och sedan lista ut vilken tidpunkt åter kan köra";
                    button3.Text = "Då föraren låter bilen stå hela dagen för att vara säker på att alkoholen inte inverkar vid körning ";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 3;

                    break;

                case 34:


                    lblQuestion.Text = "Vilken grupp har störst andel dödade personbilsförare med alkohol i kroppen?";

                    button1.Text = "Kvinnor i ålder 18-24 år";
                    button2.Text = "Män i ålder 18-24 år";
                    button3.Text = "Kvinnor i ålder 30-45 år";
                    button4.Text = "Män i ålder 30-45 år.";

                    correctAnswer = 2;

                    break;

                case 35:


                    lblQuestion.Text = "Hur kan du veta om ett läkemedel är olämpligt att använda i samband med körning?";

                    button1.Text = "Jag läser den bifogade informationen om medicinen.";
                    button2.Text = "Jag läser innehållets ekvationen på förpackningen.";
                    button3.Text = "Jag kontrollerar om förpackningen är märkt med ett rött kryss.";
                    button4.Text = "Jag kontrollerar om förpackningen är märkt med en överkorsad bil.";

                    correctAnswer = 1;

                    break;

                case 36:


                    lblQuestion.Text = "På vilket sätt ändras rörelseenergin om hastigheten höjs från 30km / h till 90km / h?";

                    button1.Text = "Rörelseenergin blir tre gånger längre";
                    button2.Text = "Rörelseenergin blir sex gånger längre ";
                    button3.Text = "Rörelseenergin blir nio gånger längre";
                    button4.Text = "Rörelseenergin blir tolv gånger längre";

                    correctAnswer = 3;

                    break;

                case 37:


                    lblQuestion.Text = "Vad påverkar reaktionssträckans längd? ";

                    button1.Text = "Fordonets hastighet.";
                    button2.Text = "Fordonets tyngd ";
                    button3.Text = "Fordonets bromsar.";
                    button4.Text = "Fordonets däck.";

                    correctAnswer = 1;

                    break;

                case 38:


                    lblQuestion.Text = "Vilket av följande påverkar reaktionssträckans längd?";

                    button1.Text = "Väglaget";
                    button2.Text = "Fordonets skick";
                    button3.Text = "Förarens tillstånd ";
                    button4.Text = "Väderleken";

                    correctAnswer = 3;

                    break;

                case 39:


                    lblQuestion.Text = "Vad händer med reaktionssträckan om du fördubblas hastigheten?";

                    button1.Text = "Reaktionssträckan förändras inte";
                    button2.Text = "Reaktionssträckan fördubblas";
                    button3.Text = "Reaktionssträckan blir 3 gånger";
                    button4.Text = "Reaktionssträckan blir 4 gånger";

                    correctAnswer = 2;

                    break;

                case 40:


                    lblQuestion.Text = "Du förutser en fara och minskar farten från 100km/h till 50km / h.Hur påverkas bromssträckan?";

                    button1.Text = "Den minskas till en femtedel";
                    button2.Text = "Den minskas till en fjärdedel.";
                    button3.Text = "Den minskas till en hälften.";
                    button4.Text = "Den minskas till en tredjedel.";

                    correctAnswer = 2;

                    break;

                case 41:


                    lblQuestion.Text = "Vad händer med bromssträckan om du ökar farten från 35km / h till 105km / h(tre gånger) ? ";
  

                      button1.Text = "Bromssträckan blir tre gånger längre";
                    button2.Text = "Bromssträckan blir sex gånger längre";
                    button3.Text = "Bromssträckan blir nio gånger längre";
                    button4.Text = "Bromssträckan blir tolv gånger längre ";

                    correctAnswer = 3;

                    break;

                case 42:


                    lblQuestion.Text = "Du kör i 30 km / h och det är torrt väglag.Bromssträckan är då ca 6 meter.Hur lång blir bromssträckan om du ökar hastigheten till 90km / h?";

                    button1.Text = "Ca 18 meter";
                    button2.Text = "Ca 24 meter";
                    button3.Text = "Ca 36 meter";
                    button4.Text = "Ca 54 meter";

                    correctAnswer = 4;

                    break;

                case 43:


                    lblQuestion.Text = "Vem ansvarar för att en 14 åring använder bilbälten under färd ?";

                    button1.Text = "Bilens ägare har alltid ansvaret";
                    button2.Text = "14-åringens föräldrar om de finns med i bilen. ";
                    button3.Text = "Föraren har alltid ansvaret.";
                    button4.Text = "14 åringen själv eftersom passagerare över 10 år bär själva ansvaret.";

                    correctAnswer = 3;

                    break;

                case 44:


                    lblQuestion.Text = "Din bil har krockkudde på passagerarplatsen fram. Hur ska du placera bilbarnstol?";

                    button1.Text = "Det är förbjudet att placera bilbarnstol i bilen";
                    button2.Text = "Jag kan placera en bilbarnstol i framsätet eftersom krockkudden alltid kopplas ur med automatik.";
                    button3.Text = "Jag måste vända en bilbarnstol så att barnet sitter framåt, om krockkudden är inkopplad";
                    button4.Text = "Jag måste placera en bilbarnstol i baksätet om krockkudden är inkopplad.";

                    correctAnswer = 4;

                    break;

                case 45:


                    lblQuestion.Text = "Vilken skyddsutrustning bör ett två-årigt barn i första hand använda när de åker bil?";

                    button1.Text = "Bilbälte";
                    button2.Text = "Bältesstol";
                    button3.Text = "Bilbarnstol";
                    button4.Text = "Bälteskudde och bilbälte";

                    correctAnswer = 3;

                    break;

                case 46:


                    lblQuestion.Text = "Hur vet du att en bilbarnstol är godkänd som en skyddsutrustning?";

                    button1.Text = "Om bilbarnstol har märke A eller D";
                    button2.Text = "Om bilbarnstol har märke T eller E";
                    button3.Text = "Alla bilbarnstolar är godkända";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;

                    break;

                case 47:


                    lblQuestion.Text = "Vilket är de viktigaste skälet till att ha en bilbarnstol monterad bakåtvänd?";

                    button1.Text = "Barnet får den bekvämaste sittställningen";
                    button2.Text = "Barnen får bättre kontakt med övriga passagerare";
                    button3.Text = "Barnets huvud och nacke får bäst skyddet";
                    button4.Text = "Barnet klarar sig bättre från att bli illamående";

                    correctAnswer = 3;

                    break;

                case 48:


                    lblQuestion.Text = "När är det dags att byta bilbarnstolen till en bälteskudde?";

                    button1.Text = "När barnet kan sitta utan stöd.";
                    button2.Text = "När barnet har fyllt två år.";
                    button3.Text = "När barnets huvud är i höjd med stolens överkant.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 3;

                    break;

                case 49:


                    lblQuestion.Text = "När får varningsblinkers användas?";

                    button1.Text = "Vid av och påstigning strax efter ett backkrön";
                    button2.Text = "Vid motorhaveri på sådan plats där man utgör fara för andra trafikanter.";
                    button3.Text = "Vid parkering framför utfart till fastighet.";
                    button4.Text = "Vid av och pålastning inom 10 meter från vägkorsningen.";

                    correctAnswer = 2;

                    break;

                case 50:


                    lblQuestion.Text = "Vad kan bli följden om du lånar ut din bil till en person som du vet inte har körkort men som ändå kör bilen?";

                    button1.Text = "Enbart den som lånat bilen kan bli straffad";
                    button2.Text = "Både jag själv och den som lånat bilen kan bli straffade.";
                    button3.Text = "Enbart jag som äger till bilen kan bli straffad.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;

                    break;

                case 51:


                    lblQuestion.Text = "Hur uppträder förare som har ett moget trafikuppträdande?";

                    button1.Text = "De visar hänsyn mot andra trafikanter";
                    button2.Text = "De tänker i första hand på sig själv";
                    button3.Text = "De håller alltid på sin rätt enligt trafikreglerna";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 1;

                    break;

                case 52:


                    lblQuestion.Text = "Vilka krav ställs på en privat handledare för att du ska kunna övningsköra med honom?";

                    button1.Text = "Handledaren måste ha körkort sedan tre år tillbaka.";
                    button2.Text = "Eleven har ansvar för körningen enligt lagen.";
                    button3.Text = "Handledaren måste vara godkänd.";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 3;

                    break;

                case 53:


                    lblQuestion.Text = "Vilket fordon är mest miljövänlig för naturen";

                    button1.Text = "Bil";
                    button2.Text = "Tåg";
                    button3.Text = "Cykel";
                    button4.Text = "Flyg";

                    correctAnswer = 3;

                    break;

                case 54:

                    pictureBox1.Image = Properties.Resources.Pärm_1_Fråga_54_page_001;

                    lblQuestion.Text = "På vilken av bilderna sitter föraren säkrast för att skydda sig mot nackskador vid påkörning bakifrån?";

                    button1.Text = "Bild A";
                    button2.Text = "Bild B";
                    button3.Text = "Bild C";
                    button4.Text = "Bild D";

                    correctAnswer = 3;

                    break;

                case 55:

                    pictureBox1.Image = Properties.Resources.CK_Trafikskola_svart_blå;

                    lblQuestion.Text = "Det är viktigt för miljön om du använder motorbromsen istället för att bromsa med fotbromsen vid avfarter och korsningar. Vilken är den viktigaste anledning för det?";

                    button1.Text = "Däcken slits mindre och det minskar spridningen av partiklar från däcken.";
                    button2.Text = "Motorn får högre arbetstemperatur när den arbetar med inbromsningen och det minskar avgasutsläppen.";
                    button3.Text = "Bensin förbrukningen minskar och därmed även avgasutsläppen";
                    button4.Text = "Bromsbeläggen slits inte och därmed sprids inga partiklar från de till naturen.";

                    correctAnswer = 3;

                    break;

                case 56:


                    lblQuestion.Text = "Hur uppfattar unga förare i allmänhet sin körförmåga? ";

                    button1.Text = "De flesta unga kvinnor tror att de kör bättre än genomsnittsbilisten";
                    button2.Text = "De flesta unga män tror att de kör bättre än genomsnittsbilisten";
                    button3.Text = "Alla unga förare tror att de kör bättre än genomsnittsbilisten";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;

                    break;

                case 57:


                    lblQuestion.Text = "Vilken påföljd är vanligast att en förare får vid grovt rattfylleri?";

                    button1.Text = "Enbart körkortsåterkallelse";
                    button2.Text = "Körkortsåterkallelse och fängelse";
                    button3.Text = "Enbart fängelse";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 2;

                    break;

                case 58:


                    lblQuestion.Text = "Kortare bilresor medför större utsläpp av avgaser per km än längre bilresor. Hur stor andel av samtliga bilresor i Sverige är kortare än 5 km?";

                    button1.Text = "Ca 15 procent";
                    button2.Text = "Ca 30 procent";
                    button3.Text = "Ca 45 procent";
                    button4.Text = "Ca 60 procent";

                    correctAnswer = 3;

                    break;

                case 59:


                    lblQuestion.Text = "Begreppet lätt lastbil är högst på 3,5 ton. Vilken vikt anses?";

                    button1.Text = "Totalvikt";
                    button2.Text = "Maxlast";
                    button3.Text = "Tjänstevikt ";
                    button4.Text = "Bruttovikt";

                    correctAnswer = 1;

                    break;

                case 60:


                    lblQuestion.Text = "Hos de flesta förare har typen av passagerare betydelse för körsättet.Vilken typ av passagerare har mest positiv effekt hos förare i de flesta åldersgrupper?";

                    button1.Text = "Jämnåriga kamrater";
                    button2.Text = "Barn";
                    button3.Text = "Föräldrar";
                    button4.Text = "Kamrater som är äldre";

                    correctAnswer = 3;

                    break;

                case 61:


                    lblQuestion.Text = "Du startar bilen en kall vintermorgon för att åka till jobbet. När börjar katalysatorn arbeta?";

                    button1.Text = "När katalysatorn är varm";
                    button2.Text = "När motorn är varm";
                    button3.Text = "När motorn startar";
                    button4.Text = "När jag kör under 3000v/min";

                    correctAnswer = 1;

                    break;

                case 62:


                    lblQuestion.Text = "Biltrafiken bidrar till att växthusgaserna ökar i atmosfären. Hur påverkas jorden av ökningen?";

                    button1.Text = "Medeltemperaturen höjs";
                    button2.Text = "Magnetfältet försvagas";
                    button3.Text = "Medeltemperaturen sänks";
                    button4.Text = "Magnetfältet stärks";

                    correctAnswer = 1;

                    break;

                case 63:


                    lblQuestion.Text = "Vilken av de här förarna löper störst risk att dödas i trafiken?";

                    button1.Text = "En 20 årig man";
                    button2.Text = "En 20 årig kvinna";
                    button3.Text = "En 35 årig kvinna";
                    button4.Text = "En 50 årig man";

                    correctAnswer = 1;

                    break;

                case 64:


                    lblQuestion.Text = "Nya bensindrivna bilar måste ha viss utrustning som minskar miljöpåverkan, Vilken?";

                    button1.Text = "Katalysatorer";
                    button2.Text = "Partikelfilter";
                    button3.Text = "Bullerreducerande däck";
                    button4.Text = "Motorvärmare";

                    correctAnswer = 1;

                    break;

                case 65:


                    lblQuestion.Text = "Hur lång sträcka kör du på 1 sekund när du kör i 90km/h?";

                    button1.Text = "25 meter";
                    button2.Text = "12 meter";
                    button3.Text = "9 meter";
                    button4.Text = "35 meter";

                    correctAnswer = 1;

                    break;

                case 66:


                    lblQuestion.Text = "Kan en bilförare bli straffad för rattfylleri om han eller hon har 0,1 promille alkohol i blodet?";

                    button1.Text = "Ja, eftersom gränsen för rattfylleri går vid 0 promille";
                    button2.Text = "Ja, om föraren bedöms olämplig som bilförare";
                    button3.Text = "Nej";
                    button4.Text = "Ja, men endast om föraren anses vållande till en trafikolycka";

                    correctAnswer = 2;

                    break;

                case 67:


                    lblQuestion.Text = "Vad kan vara orsaken till att en förare får förlängd reaktionstid ?";

                    button1.Text = "Att det är halt väglag";
                    button2.Text = "Att bilen är i dålig skick";
                    button3.Text = "Att föraren är sjuk eller trött";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 3;

                    break;

                case 68:


                    lblQuestion.Text = "Hur mycket av koldioxider från bilens avgaser tar en katalysator bort?";

                    button1.Text = "Ingenting";
                    button2.Text = "Alltihop";
                    button3.Text = "Hälften";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 1;

                    break;

                case 69:


                    lblQuestion.Text = "Vad kallas hela sträckan från att du upptäcker ett hinder tills bilen står stilla?";

                    button1.Text = "Stoppsträcka";
                    button2.Text = "Reaktionssträcka";
                    button3.Text = "Bromssträcka";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 1;

                    break;

                case 70:


                    lblQuestion.Text = "Du har en takbox på bilen. Påverkar det bränsleförbrukningen?";

                    button1.Text = "Ja, en takbox ökar alltid bränsleförbrukningen.";
                    button2.Text = "Ja, den ökar men enbart om boxen är lastad.";
                    button3.Text = "Nej, den påverkas inte";
                    button4.Text = "Inget av ovanstående";

                    correctAnswer = 1;

                    break;



            }



        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

    }
}
