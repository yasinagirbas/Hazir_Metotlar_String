namespace Hazır_Metotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Degisken  = "Dersiniz Csharp , Hoşgeldiniz";
            string Degisken2 = "Adelet yok malaasef";
           
            //Length  karakter sayısını gösterir.
            Console.WriteLine(Degisken.Length);
            
            //ToUpper Bütün karakterleri büyük yazar
            // ToLower Bütün karakterleri küçük yazar
            Console.WriteLine(Degisken.ToUpper());
            Console.WriteLine(Degisken.ToLower());
           
            //concat karakter eklemek istersek kullanmamız gereken özellik
            Console.WriteLine(string.Concat(Degisken,"Yasin"));
          
            //compareto karşılaştırmak istediğimiz değişkenler için kullanıyoruz eğer 1 değişken 2. değişkenden büyükse 1 değilse 0
            Console.WriteLine(Degisken.CompareTo(Degisken2));
            
            // compare Karşılaştırma
            Console.WriteLine(string.Compare(Degisken, Degisken2, true)); // eğer true yaparsak büyük küçük harf duyarlıdır 
            Console.WriteLine(string.Compare(Degisken, Degisken2, false));// eğer false yaparsak büyük küçük harf duyarlı olmayacaktır.
         
            //contains değişken 1 içerisinde değişken 2 var mı kontrol etmemize yarıyor içerir anlamında
            Console.WriteLine(Degisken.Contains(Degisken2)); //true dönerse vardır false dönerse içerinde yoktur.
            Console.WriteLine(Degisken.EndsWith("hoşgeldiniz")); // sonu ne ile bitiyor sorgulaması yaparbiliriz.
            Console.WriteLine(Degisken.StartsWith("Merhaba"));// Merhaba ile başlıyor mu
          
            //indexof  değişken içerinde aramamız gereken hafri arayacak ilk bulduğu yerde c nin indexsini dönecek 
            Console.WriteLine(Degisken.IndexOf("cs")); // burada kaçıncı kelime oldğunu söylecektir.
            Console.WriteLine(Degisken.IndexOf("ssd")); // hiç birşey bulamazsa -1 dönecektir.
          
            //insert ekleme komutu
            Console.WriteLine(Degisken.Insert(0,"Merhaba")); // 0. indexten başlayarak stringin başına bunu ekler
          
            //Lastindexof
            Console.WriteLine(Degisken.LastIndexOf("i")); //baktığımız zaman 1 de fazla i var son indexsi getirir bize en son i kaçıncı hafteyse onu yazar 
          
            //PadLeft // sol tarafında boşluk atmamız gerekirse kullanırız. karater sayısı yazıp boşluk koyduruyoruz.
            Console.WriteLine(Degisken+Degisken2.PadLeft(30)); // burada  değişken 2 sonuna 30 a tamamlayacak kadar boşluk ekler  
            Console.WriteLine(Degisken+Degisken2.PadLeft(30,'*')); // burada 30 harfe gelince * koyacaktır.
         
            //PadRight sağına isteğimiz karakter sayısına göre boşluk koyma 
            Console.WriteLine(Degisken.PadRight(50)+Degisken2); //50 tamamlayacak kadar boşluk ekledi.
            Console.WriteLine(Degisken.PadRight(50,'-')+Degisken2); // 50 tamamlayacak kadar - ekledi
          
            //Remove silme komutu
            Console.WriteLine(Degisken.Remove(10));// 10 indexten başlayarak sonuna kadar siler 
            Console.WriteLine(Degisken.Remove(5,3)); //5 karakterden başlayarak 3 karakter sil 
            Console.WriteLine(Degisken.Remove(0,1));//en başta ki karakteri siler
          
            //Replace değiştir komutu
            Console.WriteLine(Degisken.Replace("csharp","C#")); // burada csharp yazısını c# olarak değiştir dedik
            Console.WriteLine(Degisken.Replace(" ","*")); // Burada boşlukları * yaptık.
         
            //** split boşluklara göre parçala ve bir diziye aktar
            Console.WriteLine(Degisken.Split(' ')[1]); //burada boşluklara göre parçala ve bir dizitye ata ve bana 1 indexi getir.
           
            //Substring
            Console.WriteLine(Degisken.Substring(4)); // 4 indexten başlayaark cümlenin sonuna kadar getirir
            Console.WriteLine(Degisken.Substring(4,6)); // 4 indexten başlayarak 6 karakter getir deriz
          // tamamlandı
        }
    }
}
