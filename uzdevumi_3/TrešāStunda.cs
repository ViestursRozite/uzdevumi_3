using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace uzdevumi_3
{
    public static class TrešāStunda
    {
        //pirmais piemērs
        //Šeit definējam, kas datoram jādara tad, kad izsauksim funkciju
        //Uzdevumiemir uzrakstīti automatizēti testi
        //atver testu logu
        //View / Test Explorer
        //Funkcijas tests sākas ar funkcijas nosaukumu, pēc tam seko sagaidāmās darbības, pašās beigās pierakstīts test
        //Palaid testu ar pildīto zaļo bultiņu Test Explorer logā
        public static int Saskaita3VeselusSkaitļusPiemērs(int int1, int int2, int int3)
        {
            return int1 + int2 + int3;
        }
        //Zaļais aplis ar ķeksīti norāda ka tests izpildās


        //piemērs ar testu kas neizpildās
        //palaid testu
        //Error message redzams, kas nav preizi
        //Funkcijai jāatgriež int nevis string, 

        //funkcijas tips string jānomaina uz int
        public static string FunkcijaAtgriežToPašuIntKoTaiPadod(int veselsSkaitlis)
        {
            //rindā return jānodzēš ".ToString()" 
            return veselsSkaitlis.ToString();
        }
        // palaid testu un pārbaudi vai tas izpildās


        //palaid testu un paskaties kas notiek
        //pārbaudi Error List... 
        public static void Uzdevums1(int i)
        {
            //Līdz šim esam tikai saņēmuši errorus, 
            //Šeit tiek mests "Nav izstrādāta funkcija" errors
            //to var apskatīt ierakstot
            //TrešāStunda.Uzdevums1(1);
            //Program.cs pēdējā rindā...
            throw new NotImplementedException();
        }


        //Uzrakstīsim jaunu metodi.
        //Metodes, tāpat kā cipari vai teksts glabājas kastītēs jeb klasēs
        //Pašlaik rakstam metodes TrešāStunda klasē

        //Metodei jāsākas ar public, lai to varētu izsaukt ārpus šīs lapas
        
        //pēc tam static, lai mums nebūtu jāuztaisa
        //TrešāStunda mainīgais = new TrešāStunda();
        //mainīgais pirms metodes saukšanas

        //metodei jāatgriež int
        //metodei jāņem viens parametrs- tas kas ir iekavās. int tips
        //metodei jāatgriež padotais skaitlis +1

        //Uzraksti metodi Uzdevums2 nākamajā rindā

        //Pārbaudi ka Visi trīs 2.uzdevuma testi izpildās


        //3. uzdevums
        //Iepazīsimies ar tipu string jeb teksts
        //tekstu var apvienot piemēram
        //"Astotā" + " Klase"; kļūs par "Astotā Klase"
        //Tāpat arī:
        //string vārds2 = "Gaidām";
        //vārds2 + " Brīvlaiku, ai kā " + vārds2;  kļūs par "Gaidām Brīvlaiku, ai kā Gaidām"

        //uzraksti publisku un statisku funkciju
        //kas atgriež string
        //ar vienu parametru tekstam
        //funkcijai jāatgriž padotais vārds divas reizes
        //Piem. padod Func("pareizi") un func. atgriež "pareizipareizi"

        //Uzraksti metodi Uzdevums3 nākamajā rindā

        //Pārbaudi ka Visi trīs 3.uzdevuma testi izpildās


        //4. uzdevums
        //atceries funkcijas kas pieņem vairākus parametrus atdala ar komatu:
        //string Funkc(string vārds, int skaitlis, bool jāVaiNē)

        //uzraksti publisku un statisku funkciju
        //kas atgriež string
        //ar vienu parametru tekstam un vienu veselam skaitlim
        //funkcijai jāpievieno padotais cipars vārda beigās
        //piem.: Func("Manas stundas šodien sk. :", 6); "atgriež Manas stundas šodien sk. :6"
        //Atceries Ja Tu pievieno gandrīz jebko klāt string piem.: "wooHoo" + 6.8 kļūs par "wooHoo6.8", tātad tas arī pārvērtīsies par string

        //Uzraksti metodi Uzdevums4 nākamajā rindā

        //Pārbaudi ka Visi trīs uzdevuma testi izpildās


        //5. uzdevums
        //Reizēm mums vajag esošā tekstā ievietot šo to
        //Kā ievietot 256 tekstā "Manā Steam account ir X spēles" ? → "Manā Steam account ir 265 spēles"
        //Varam izmantot string interpolation
        //Galvenais ko varam iemācīties programmējot ir spēja lasīt tehnisko dokumentāciju...
        //Ieskaties https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        //Izmantosim piemēru ar {} iekavām teksta ievietošanai
        //Kā jāraksta teksts lai tajā varētu iespraust vērtību no mainīgā?

        //uzraksti publisku un statisku funkciju
        //kas atgriež string
        //ar vienu parametru tekstam un vienu skaitlim, tie jāievieto:
        //                      ↓                    ↓ 
        //               "Manā { } šobrīd ielādētas { } izklaides aplikācijas"

        //Uzraksti metodi Uzdevums5 nākamajā rindā 

        //Pārbaudi ka Visi trīs uzdevuma testi izpildās


        //6.uzdevums
        //Kādēļ mēs rakstam funkcijas kas dara tikai vienu lietu?

        //metodes ķermenī varam izsaukt iepriekš uzrakstītu funkciju
        //piem.: string teikums = Uzdevums5("telefonā", 13); tātad mainīgajā/kastītē   teikums    glabāsies "Manā telefonā šobrīd ielādētas 13 izklaides aplikācijas"
        //Uzraksti metodi, kas vienmēr atgriž 
        //"Manā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijas"
        //*atkārtojas 5 reizes
        //Vai šai metodei nepieciešami parametri?

        //Uzraksti metodi Uzdevums6() nākamajā rindā

        //Pārbaudi ka abi uzdevuma testi izpildās


        //7. uzdevums
        //Kā izmanto string interpolation ar mainīgajiem?
        //Uzdevums ir atgriest tekstu :
        //"Viens teikums {}, divi teikumi {}, pieci teikumi {}, divdesmit teikumi {}"
        //ievietojot spicajās iekavās attiecīgo skaitu teikumu no Uzdevums5("telefonā", 13);
        //atceries iepriekšējos uzdevumos uzdevumus3() dubulto tekstu un Uzdevums6() atgriež 5 teikumus
        //5 * 2 * 2 = 20  :/

        //Metodei jāatgriež teksts
        //Uzraksti metodi Uzdevums7() nākamajā rindā

        //Pārbaudi ka abi uzdevuma testi izpildās


        //           Boolean
        //true un false vērtības
        //bool sēžu = true;
        //bool lidoju = false;
        //bool nuūNēNuuJāaa = 5 == 5; true pieci ir vienāds ar pieci
        //programmēšanā == nozīmē to pašu ko = matemātikā
        //bool sēdēšanaNavLidošana = sēžu != lidoju; true
        //!= ir pretējā zīme ==
        //<= ,mazāks-vienāds
        //>= ,lielāks-vienāds
        //< ,mazāks
        //> ,
        //== ,ir vienāds
        //!= ,nav vienāds
        //&& ,un
        //
        // ,  ,  , utt.


        //8. uzdevums
        //Izlabo kļūdu, ja gribas pusdienas, tad jāiet tajās
        public static bool Uzdevums8_VaiJāietPusdienās(bool gribasĒst)
        {
            bool ejuPusdienās = false;

            if (gribasĒst)
            {
                return ejuPusdienās;
            }
            else
            {
                return !ejuPusdienās;//ievēro ka šajā rindā ir izsaukuma zīme, bool tipa kontekstā tā nozīmē "pretējā vērtība"
            }
        }
        //Palaid testus


        //9.uzdevums
        //Izlabo kļūdu
        //viens no testiem neizpildās, iespējams jāmaina loģikas struktūra
        //iepauzēšu spēli tikai tad ja man lūdz un tā nav online spēle
        public static bool Uzdevums9_VaiIepauzēšuSpēli(bool manLūdzIepauzētSpēli, bool tiešsaistesSpēle)
        {
            bool esIepauzēšuSpēli = false;

            //                       un
            //                       ↓↓
            if (manLūdzIepauzētSpēli && tiešsaistesSpēle)//
            {
                esIepauzēšuSpēli = false;
            }
            //                        nav vienāds
            //                            ↓↓
            else if (manLūdzIepauzētSpēli != tiešsaistesSpēle)
            {
                esIepauzēšuSpēli = true;
            }
            else
            {
                esIepauzēšuSpēli = false;
            }

            return esIepauzēšuSpēli;
        }
        //Pārbaudi ka visi 4 testi izpildās 


        //10.uzdevums
        //Uzraksti metodi Uzdevums10VērtībaIrMaza , kas saņems divus skaitļus un atgriezīs true ja to summa ir <= 1000

        //Raksti metodi Uzdevums10VērtībaIrMaza nākamajā rindā
        
        //visiem 4 testiem jāizpildās


        //11.uzdevums
        //Tagad kad varam veikt loģiskās pārbaudes, varam automatizēt teksta aizpildi
        //izveidosim metodi, kas vienmēr atgriež vienāda garuma tekstu - 30 zīmes, jeb 30 char
        //tātad jāizveido kastīte 30 char
        //char[] rezult = new char[30]()

        //public static bool Uzdevums11_AtgriežVārdu



        //                             Misc funkcijas uzdevumu pārbaudei
        public static bool HasMethod(string methodName)
        {
            try
            {
                //null ja nav metodes
                MethodInfo mInfo = typeof(TrešāStunda).GetMethod(methodName);
                if (mInfo != null) 
                {
                    return true;
                }
            }
            catch (AmbiguousMatchException)
            {
                // ambiguous means there is more than one result,
                // which means: a method with that name does exist
                return true;
            }
            //false ja nav metodes
            return false;
        }
    }
}
