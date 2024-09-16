
// See https://aka.ms/new-console-template for more information

string choice = "";
Console.WriteLine("Du vaknar sent på natten av konstiga ljud utanför ditt rum");
Console.WriteLine("Till din vänstra sida finns ditt fönster som leder till din gård");
Console.WriteLine("Framför dig är rummets dörr, som tar dig till ljuden");
Console.WriteLine("Vart kommer du att gå? Vänster eller Framåt?");
choice = Console.ReadLine();

if (choice == "Vänster")
{
Console.WriteLine("Innan du hoppar från ditt fönster inser du att det finns en risk för skada, men gör det iallafall");
Console.WriteLine(" Detta resulterar till att du landar fel och bryter ditt ben");
Console.WriteLine("Innan du ens hinner skrika ut smärtan du har, hör du någon komma mot dig med snabba fotsteg");
Console.WriteLine("Skuggan kommer närmre dig och ljudet av personens fotsteg blir starkare");
Console.WriteLine("Till slut hör du en röst som liknar vara din grannes och skuggan plötsligt stanna innan du svimmar");
Console.WriteLine("Du levde, men behövde sitta i en rullstoll för resten av ditt liv utan någon information om skuggan");
choice = Console.ReadLine();
}

else if (choice == "Framåt")
{


Console.WriteLine("Du öppnar din dörr och ser framför dig 2 mörka ingångar.  ");
Console.WriteLine("På den vänstra ingången hörs det ingenting, medan i den högra så är ljudet väldigt starkt");
Console.WriteLine("Vart kommer du att gå? Vänster eller Höger?");
choice = Console.ReadLine();


}
if (choice=="Vänster")
{
Console.WriteLine("Du öppnar långsamt dörren och möts av ett mörker som är nästan kompakt");
Console.WriteLine(" Du går djupare in i rummet och börjar plötsligt känna dig väldigt yr.");
Console.WriteLine("När du försöker gå ut ur rummet möts du av en skugga ");
Console.WriteLine("Och innan du ens inser det, känner du en skarp smärta i bröstet samtidigt som du faller omkull");
Console.WriteLine("Du dog och mördaren fångades aldrig");
 choice = Console.ReadLine();
}
else if (choice == "Höger")
{
Console.WriteLine("Du tvekar för en sekund men öppnar dörren snabbt och möts av ett trasig fläkt som har en klocka ihopklisstrad vid den ");
Console.WriteLine("När du går närmre så uppfattar du att detta är inte en vanlig klocka, utan istället en bomb");
Console.WriteLine("Tjugo,Nitton,Arton, Sjutton, Sexton, Femton");
Console.WriteLine("Med adrenalinet på högvarv försöker du snabbt samla dina tankar och fokusera på din omgivning");
Console.WriteLine("Du drar bomben isär från fläkten och kastar den utanför det närmaste fönstret");
Console.WriteLine("BOOOM, var det sista du hörde innan du kastades mot väggen av den kraftiga explosionen");
Console.WriteLine("Du överlevde men explosionen orsakade ett väldigt stort kausalitet bland dina grannar");
 choice = Console.ReadLine();


}
Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();
