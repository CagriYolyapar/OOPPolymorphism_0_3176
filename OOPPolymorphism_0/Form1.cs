using OOPPolymorphism_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPolymorphism_0
{

    /*
        Inheritance prensibinde bir Base Class'ın erişim belirteci miras verdigi class'lardan daha düsük olamaz...

        Siz Inheritance prensibini uygulamak icin illa baska bir prensibe baglı kalmak zorunda degilsiniz...Mesela INheritance prensibini uygulamak icin Encapsulation prensibini uygulamak zorunda degilsiniz...Encapsulation, Inheritance olmadan rahatca kullanılabilir...

    Ancak Polymorphism prensibi icin mecburi önce Inheritance olmalıdır...


     ------------------------Polymorphism(Cok Bicimlilik)-------------------------------


    Diger sınıflara miras veren sınıfımın (Base Class'ın) yapıları tamamıyla türeyen sınıfa (child class'a) aktarılacaktır...Ancak base class'taki yapılardan bazıları farklı sınıflarda farklı şekillerde davranmak isteyebilir...Mesela bir Karakter sınıfı düsünün...Class'ta metodumuz olsun...Bu Karakter sınıfından miras alan 3 tane sınıf olsun(Büyücü, Okcu, Sovalye)...Bu miras alan sınıflarımızın her biri Saldır metodunu farklı bir şekilde kullanmak isteyebilir...Bu durumda Saldır() metodunun polymorphism prensibine girmesi gerekir...Yani bu metodun virtual keyword'u ile işaretlenmesi gerekir.İsteyen bir sınıf metodun orijinal halini kullanabilir. İsteyen bir sınıf da metodu degişik şekilde kullanabilir...

    Polymorphism'de elinizde olan metodun kullanılacak temel bir işlevi vardır ama baska yerde bu işlev isterseniz degişebilir...Polymorphism icin temel bir görevin olması gereklidir...

    Polymorphism icin öncelikle base class'ta tanımlanan yapının bu prensibe maruz kalabilecegi belirtilmek zorundadır...Bunu da ilgili yapıda virtual keyword'u kullanarak yaparız...Bu virtual keyword'u bize su anlamı katar : "Bu yapı, miras verilen yerde istenirse oldugu gibi kullanılabilir, istenirse de degiştirilebilir"...virtual keyword'u miras verilecek sınıfta o yapının görevini degiştirme imkanını override dedigimiz bir keyword ile sunar. Yani ilgili yapıyı miras alan Class'ta o yapının görevini degiştirmek istiyorsak önce override yazarak ilgili yapıyı degiştirmek istedigimizi bildiririz.Ama tabii ki bu degişiklik sadece override yazdıgımız (ilgili miras alan Class'ta ) olacaktır...Base Class'ta hala orijinal davranısını korur.

    Virtual asamasını gectikten sonra türeyen sınıfta degişik  şekilde kullanmak istedigimiz metodu getirmek icin override keyword'unu yazıp bir bosluk bırakırsanız virtual olarak işaretlenmiş metotlar karsınıza gelip size büyük bir yazım kolaylıgı saglyacaktır... Polymorphism zorunlu bir şey degildir siz sadece bir yapının görevini miras verilen yerde degiştirmek isterseniz kullanırsınız...

    virtual keyword'unu sadece bir metoda veya sadece bir property'e verebilirsiniz....Ancak virtual keyword'unu field'lara yazamazsınız. Cünkü virtual "istersen bunun görevini degiştirebilirsin" demektir...Degişkenler ise görev barındırmaz...Degişkenler deger barındırır...


    virtual keyword'unu private erişim belirtecleri ile kullanamazsınız...

     
     */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Personel p = new Mudur();

            //p.Calis(); //Personelin icerisinde tuttuğu tip eger polymorphism ile bu metodu override etmiş ise o metodun override edilmiş hali calısacaktır...





            //List koleksiyonuna alttaki gibi tam tanımlandıgı anda eleman ekleyebilirsiniz...
            List<Personel> personeller = new List<Personel>
            {
                new Egitmen(), new Mudur(), new Danisman(), new Hizmetli()
            };

            //foreach (Personel item in personeller)
            //{
            //    item.Calis();
              
            //}



        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Mudur m = new Mudur();
            m.Isim = "Betul";
            m.SoyIsim = "Sahin";
            LstSonuc.Items.Add(m); //m.ToString(); aslında burada yapılan durum m nesnesinin string'e donusturulmesidir...Bu yüzden Personel Class'ında ToString() metodunu polymorphism'e girebilir hale getirdik ki istedigimiz şekilde bir temsil görevi yapabilsin...
        }
    }
}
