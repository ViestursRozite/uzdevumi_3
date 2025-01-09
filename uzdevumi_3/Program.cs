using uzdevumi_3;

//Program.cs ir koda fails no kura visa mūsu uzrakstītā programma uzsāk darbību.

// int - mainīgā tips, tikai veseli skaitļi


//         Ieskats tipos un mainīgajos
//programmēšanā viena "=" zīme nozīmē "no šī brīža būs"
int piemērsArInt = 0;//mainīgajā pašlaik ir 0

// mainīgie ir uztverami kā kastītes...
int a = 1;//kastē a ir 1 
int b = 2;//kastē b ir 2

a = b;//kastē a "no šī brīža būs" 2
// Kādēļ 2 un ne b?
//kastē a var ielikt tikai veselu skaitli
//b ir  kaste
b = 3;//nomainam vērtību b kastītē
//Tagad esam nomainījuši vērtību, kas šobrīd glabājas a ?
Console.WriteLine("mainīgajā a, šobrīd glabājas " + a);


//                   funkcijas izsaukšana no klases(mapīte funkcijām)

//kastē piemērsArInt no šī brīža būs 15
piemērsArInt = TrešāStunda.Saskaita3VeselusSkaitļusPiemērs(6, 8, 1);//6 + 8 + 1 = 15

//Lai gan failu pārlūkā, savā mapītē neredzēsim "Saskaita3VeselusSkaitļusPiemērs.exe" varam uztvert šo kā
//Dator palaid programmu 
//         .../TrešāStunda/Saskaita3VeselusSkaitļusPiemērs.exe

//".exe" - izpildāms fails, piemēri: Firefox.exe, Steam.exe, VisualStudio.exe

//apskatīsim ko atgrieza funkcija "Saskaita3VeselusSkaitļusPiemērs"
Console.WriteLine("mainīgajā piemērsArInt, šobrīd glabājas " + piemērsArInt);


//                    iepazīsimies ar klasēm 
//atver TrešāStunda.cs Solution explorerī
//vai pieturi ctrl un uzklikšķini uz 
// ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
TrešāStunda.Saskaita3VeselusSkaitļusPiemērs(6, 8, 1);

//Vieta pierakstiem:
TrešāStunda.Uzdevums1(1);
