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
        //===================variable===================
        public int SUM;
        //===================properties===================
        string avtomobilTuri { get; set; }
        string MoyNomi { get; set; }
        int balonlarSoni { get; set; }
        int bosim { get; set; }
        bool TanOldiOyna { get; set; }
        bool TanOrqaOyna { get; set; }
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
        public Service(string avtomobilTuri,string MoyNomi, int balonlarSoni,int bosim)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
        }
        public Service(string avtomobilTuri,string MoyNomi, int balonlarSoni,int bosim, bool TanOldiOyna)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
            this.TanOldiOyna = TanOldiOyna;
        }

        public Service(string avtomobilTuri,string MoyNomi,int balonlarSoni,int bosim, bool TanOldiOyna, bool TanOrqaOyna)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
            this.TanOldiOyna = TanOldiOyna;
            this.TanOrqaOyna = TanOrqaOyna;
        
        }
        public Service(string avtomobilTuri,string MoyNomi, int balonlarSoni,int bosim, bool TanOldiOyna, bool TanOrqaOyna,bool labavoy)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
            this.TanOldiOyna = TanOldiOyna;
            this.TanOrqaOyna = TanOrqaOyna;
            this.labavoy = labavoy;
        }
        public Service(string avtomobilTuri, string MoyNomi, int balonlarSoni, int bosim, bool TanOldiOyna, bool TanOrqaOyna, bool labavoy,bool krugovoy)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
            this.TanOldiOyna = TanOldiOyna;
            this.TanOrqaOyna = TanOrqaOyna;
            this.labavoy = labavoy;
            this.krugovoy = krugovoy;
        }
        public Service(string avtomobilTuri, string MoyNomi, int balonlarSoni, int bosim, bool TanOldiOyna, bool TanOrqaOyna, bool labavoy, bool krugovoy, string avtoPart)
        {
            this.avtomobilTuri = avtomobilTuri;
            this.MoyNomi = MoyNomi;
            this.balonlarSoni = balonlarSoni;
            this.bosim = bosim;
            this.TanOldiOyna = TanOldiOyna;
            this.TanOrqaOyna = TanOrqaOyna;
            this.labavoy = labavoy;
            this.krugovoy = krugovoy;
            this.avtoPart = avtoPart;
        }


        //===================methods===================
        public int MoyAlmashtirish()
        { 
            if (avtomobilTuri=="Nexia" && MoyNomi=="80")
            {
                return SUM += 900;
            }
            else if (avtomobilTuri == "Nexia" && MoyNomi == "90") 
            {

                return SUM += 950;
            }
            else if (avtomobilTuri == "Matiz" && MoyNomi == "80")
            {

                return SUM += 600;
            }
            else if (avtomobilTuri == "Matiz" && MoyNomi == "90")
            {

                return SUM += 650;
            }
            else
            {
                return SUM;
            }
        }
        public int BalonDamlash()
        {
            if (bosim < 40)
            {
                return SUM += bosim * balonlarSoni * 3;
            }
            else
            {
                return SUM;

            }
        }


        public int Tanirovka() 
        {
            if (krugovoy == false)
            {
                if (TanOldiOyna==true && TanOrqaOyna==true && labavoy==true)
                {
                    krugovoy = true;                
                }
                if (TanOldiOyna == true) 
                { 
                    return SUM += 100;
                }
                if (labavoy == true) 
                { 
                    
                    return SUM += 300; 
                
                }
                if (TanOrqaOyna == true)
                { 
                    return SUM += 150;
                }
                else
                {
                    return SUM;
                }
            }
            else
            {
                return SUM += 550;
            }
        
        }
        public int Polirovka() 
        { 
            if (avtomobilTuri == "Nexia" && avtoPart=="eshik") 
            {
                return SUM += 600;
            }
            else if (avtomobilTuri == "Nexia" && avtoPart == "bagaj")
            {
                return SUM += 900;
            }
            else if (avtomobilTuri == "Matiz" && avtoPart == "bagaj")
            {
                return SUM += 850;
            }
            else if (avtomobilTuri == "Matiz" && avtoPart == "eshik")
            {
                return SUM += 450;
            }
            else
            {
                return SUM += 1000;
            }

        }
        public int MatorniYuvish() 
        { 
            if (avtomobilTuri == "Nexia")
            {
                return SUM += 700;
            }
            else if (avtomobilTuri == "Matiz")
            {
                return SUM += 500;
            }
            return SUM;
        
        }
        public void getSum()
        {
            Console.WriteLine($"Javi {SUM} tolashingiz kk");

        }
    }
}