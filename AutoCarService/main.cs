/*Service degan class
unda propertylar boladi 

AvtoService 
 methodlar
MoyAlmashtirish, => avtomobil turi, va MoyNomi => narxini
BalonDamlash, => balonlar soni, bosim => narxini
Tanirovka, => AvtomobilTuri, Qaysi oynalarni tanirovka qilishiga qarab, oldi oyna, orqa oyna, kurgovoy, labavoy
=> xizmat narxini
Polirovka, => avtomobil turi, homashyo turiga qarab, avtomobil detaliga qarab narx tayinlansin => va narxini hisoblab bersin
MatorniYuvish xizmati, => avtomobil turiga qarab => narxini hisoblab bersin
*/

using lab;
class App
{
    public static void Main(string[] args)
    {
        Service gosusluga = new Service("Nexia");
        gosusluga.Tanirovka();
        gosusluga.MatorniYuvish();
        gosusluga.BalonDamlash();
        gosusluga.Polirovka();
        gosusluga.MoyAlmashtirish();
        gosusluga.getSum();
    }
}