using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Globalization;

namespace Daspro_6;

class Program
{
    static void Main(string[] args)
    {
        // Game Tic Tac Toe
        char pemain = 'X';
        
        bool gameSelesai = false;
        char[,] papan =new char [3,3];
        init (papan);
        while(!gameSelesai){
            Console.Clear();
            
            TampilkanPapan(papan);
            // Inisiate Error/Bug
            try{
            Console.Write("Baris (0-2) :");
            int baris = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kolom (0-2) :");
            int kolom =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Baris : "+baris+"Kolom"+kolom);
            papan[baris,kolom]=pemain;

        } catch(Exception ex){
            Console.WriteLine("Error :"+ex.Message);
        }
        if(CekMenang(papan,pemain)){
            TampilkanPapan(papan);
            Console.WriteLine(pemain+ " menang,terima kasih sudah bermain");
            Console.Read();
            gameSelesai=true;
        }else if (CekSeri(papan)){
            TampilkanPapan(papan);
            Console.WriteLine("Permainan seri!");
            Console.Read();
            gameSelesai=false;
        }
        pemain = GantiPemain(pemain);
        }
    }
    static char GantiPemain(char pemain){
        if(pemain=='X'){
            return 'O';
        }else{
            return 'X';
        }
    }
    static bool CekSeri(char[,]papan){
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                if(papan[i,j]==' ') return false;
            }
        }
        return true;
    }
    static bool CekMenang(char[,]papan,char pemain){
// cek baris dan kolom
        for(int i=0;i<3;i++){
            if(papan[i,0]== pemain && papan[i,1]== pemain && papan[i,2] == pemain)
            return true;
            if (papan[0,i]== pemain && papan [1,i]== pemain && papan[2,i] == pemain)
            return true;

        }
        // cek diagonal
        if(papan[0,0]== pemain && papan [1,1]== pemain && papan[2,2] == pemain)
        return true;
        if (papan[0,2]== pemain && papan [1,1]== pemain && papan[2,0] == pemain)
        return true;

        return false;
    }
    static void TampilkanPapan(char[,] papan)
    {
        Console.WriteLine("  | 0 | 1 | 2 |");
        for(int baris=0;baris<3;baris++){
            Console.Write(baris + " | ");
            for(int j=0;j<3;j++){
                Console.Write(papan[baris,j]);
                Console.Write(" | ");
            }
            Console.WriteLine();
        }
    }
    static void init(char[,]papan){
        for(int baris=0;baris<3;baris++){
            for(int kolom=0;kolom<3;kolom++){
                papan[baris,kolom]=' ';
            }
        }
    }
        /*
        // inisialisasi matriks 3 x 3
       int [,] matriks1 = new int[3,3];
       int[,] matriks2 = new int[3,3]{{9,8,7},{6,5,4},{3,2,1}};

       for (int i=0;i<3;i++)
       {
        for (int j=0;j<3;j++)
        {
            matriks1 [i,j]=i * 3 + j+ 1;
            matriks2 [i,j]=1;
            
        }
       }
       for (int i=0;i<3;i++)
       {
        for (int j=0;j<3;j++)
        {
            matriks1[i,j]= matriks1[i,j]+matriks2[i,j];
        }
       
       }
       for (int i=0;i<3;i++)
       {
        for(int j=0;j<3;j++)
        {
            Console.Write(matriks1 [i,j]+ "\t");
        }
        Console.WriteLine();
        // penambahan 
       }
       Console.WriteLine("___________________");
       int [,] tambah = PenambahanMatriks(matriks1,matriks2);
        
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            Console.Write(tambah[i,j]+"\t");
        }
        Console.WriteLine();
    }
    }
    static int[,] PenambahanMatriks(int[,] matriks1, int[,]matriks2){
        int[,]hasil=new int[3,3];
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                hasil[i,j]= matriks1[i,j]+ matriks2 [i,j];
            }
        } 
        return hasil;*/
    }

        
    


