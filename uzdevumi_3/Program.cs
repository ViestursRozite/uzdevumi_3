using uzdevumi_3;

//Program.cs ir koda fails no kura visa mūsu uzrakstītā programma uzsāk darbību.
//programma izpildīsies rindu pa rindai. Viss notiek no augšas uz leju


//         Ieskats tipos un mainīgajos
// int - mainīgā tips, tikai veseli skaitļi
// mainīgo varam nosaukt kādā vārdā gribam
//programmēšanā viena "=" zīme nozīmē "no šī brīža būs"
int piemērsArInt = 0;//mainīgajā piemērsArInt pašlaik glabājas 0


// mainīgie ir uztverami kā kastītes...
int a = 1;//kastē a ir 1 
int b = 2;//kastē b ir 2
a = b;//kastē a "no šī brīža būs" skaitlis, kas tieši šajā brīdī ir mainīgajā b
b = 3;//nomainam vērtību b kastītē

//Tagad esam nomainījuši vērtību, kas šobrīd glabājas a ?
Console.WriteLine("mainīgajā a, šobrīd glabājas " + a);//dator uzraksti konsolē "mainīgajā a, šobrīd glabājas [a vērtība]"
//Ar zaļo bultiņu augšā pa vidu palaid programmu uzdevumi_3 un paskaties...


//atceries mainīgie ir tikai kastītes no kā "paņem" vērtību vai "ieliek" vērtību
//Programmēšanā x = 0 nozīmē iksā tagad glabājas 0
//matemātikā x = 0 nozīmē ikss ir nulle. Nesajauc šos 2 dzīvniekus :)




//                   funkcijas izsaukšana no klases(mapīte funkcijām)

//mainīgajā piemērsArInt pašlaik stāv 0 *11. rindā izveidojām mainīgo un uzreiz tur ielikām 0
piemērsArInt = TrešāStunda.Saskaita3VeselusSkaitļusPiemērs(6, 8, 1);//Dator! mainīgajā jeb "Kastē" piemērsArInt no šī bŗīža glabā to ko funkcija Saskaita3VeselusSkaitļusPiemērs šajā momentā atgriež
//mainīgajā piemērsArInt pašlaik stāv 15




//Nodzēs "//" 35. rindā un paskaties 


//Lai gan failu pārlūkā, savā mapītē neredzēsim "Saskaita3VeselusSkaitļusPiemērs.exe" varam uztvert šo kā
//Dator palaid programmu 
//         .../TrešāStunda/Saskaita3VeselusSkaitļusPiemērs.exe

//".exe" - izpildāms fails, piemēri: Firefox.exe, Steam.exe, VisualStudio.exe

//apskatīsim ko atgrieza funkcija "Saskaita3VeselusSkaitļusPiemērs"
//Console.WriteLine("mainīgajā piemērsArInt, šobrīd glabājas " + piemērsArInt);


//                    iepazīsimies ar klasēm 
//atver TrešāStunda.cs Solution explorerī
//vai pieturi ctrl un uzklikšķini uz 
// ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
TrešāStunda.Saskaita3VeselusSkaitļusPiemērs(6, 8, 1);

//Vieta pierakstiem:

