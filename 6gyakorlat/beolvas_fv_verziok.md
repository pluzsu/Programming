```c#
struct Tkonyv{
            public string cim, szerzo;
            public int psz, kpsz;
        };

/* tömb, cím szerinti átadással */
static void Beolvas(out int n, out Tkonyv[] mibe) {
   int.TryParse(Console.ReadLine(),out n);
   mibe = new Tkonyv[n];
   for (int i=0; i<n; i++) {
       string[] sv=Console.ReadLine().Split(";");
       Tkonyv tsv;
       tsv.cim = sv[0];
       tsv.szerzo = sv[1];
       int.TryParse(sv[2], out tsv.psz);
       int.TryParse(sv[3], out tsv.kpsz);
       mibe[i] = tsv;
   }
}

/* Lista, visszatérési értékként */
static List<Tkonyv> Beolvas2() {
            int n;
            List<Tkonyv> sl=new List<Tkonyv>();
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i < n; i++) {
                string[] sv = Console.ReadLine().Split(";");
                Tkonyv tsv;
                tsv.cim = sv[0];
                tsv.szerzo = sv[1];
                int.TryParse(sv[2], out tsv.psz);
                int.TryParse(sv[3], out tsv.kpsz);
                sl.Add(tsv);
            }
            return sl;
        }

static void Main(string[] args) {
            int n, db;
            Tkonyv[] k;
            Beolvas(out n, out k);

            List<Tkonyv> kl;
            kl = Beolvas2();
  ...

```
