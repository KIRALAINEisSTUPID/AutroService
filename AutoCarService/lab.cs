/*
 * 
 *   Project 
 * 
 * Service degan class
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

namespace lab // namespace opened to call
{
    class Service //class created
    {

        //===================properties===================
        string avtomobilTuri { get; set; }
        string MoyNomi { get; set; }
        int balonlarSoni { get; set; }
        int bosim { get; set; }
        int TanOldiOyna { get; set; }
        int TanOrqaOyna { get; set; }
        bool labavoy { get; set; }
        bool krugovoy { get; set; }
        string avtoPart { get; set; }
        //===================Constructor===================
        public Service(string avtomobilTuri)
        {
            this.avtomobilTuri = avtomobilTuri;
        }
        public Service(string avtomobilTuri,string MoyNomi)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
        }
        public Service(string avtomobilTuri,string MoyNomi, int balonlarSoni)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
        }
        public Service(string avtomobilTuri,string MoyNomi, int balonlarSoni,int bosism)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
        }
        public Service(string avtomobilTuri,string MoyNomi, int balonlarSoni,int bosim,int TanOldiOyna)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
            this.TanOldiOyna = TanOldiOyna;
        }

        public Service(string avtomobilTuri,string MoyNomi,int balonlarSoni,int bosim,int TanOldiOyna,int TanOrqaOyna)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
            this.TanOldiOyna =
            this.TanOrqaOyna = TanOrqaOyna;
        
        }
        public Service

        //===================methods===================
        public int MoyAlmashtirish() { return 0; }
        public int BalonDamlash() { return 0; }
        public int Tanirovka() { return 0; }
        public int Polirovka() { return 0; }
        public int MatorniYuvish() { return 0; }
    }
}