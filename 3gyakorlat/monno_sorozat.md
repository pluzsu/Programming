
[számsorozat - monoton növekedő-e](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACqtWKi5ITc5My0xOLMnMz1OyUnJKtVLSUSpJLS4pVrKKrlZKSSxJVLJSUtJRykvMTYWwilKLS3NKlKyMamNrAdhsq6pCAAAA#)
<code>
Be: n∈N, s∈Z[1..n]
Ki: monno∈L
Ef: n>=2
Uf: monno=nem VAN(i=1..n-1,s[i]>s[i+1])
/* eldöntés 
Uf: van=VAN(i=e..u,T(i)) 
van  ~ nem monno
e..u ~ 1..n-1
T(i) ~ s[i]>s[i+1]*/
</code>

`
  static void Main(string[] args) {
     int n;
     Console.Write("n= ");
     int.TryParse(Console.ReadLine(),out n);
     int[] s= new int[n];
     string sv = Console.ReadLine();
            string[] svt = sv.Split(" ");
            for (int i = 0; i < n; i++) {
                int.TryParse(svt[i], out s[i]);
            }
            // megoldás
            bool monno = true;

            int i = 0;
            while (monno && i<n-1) {
             if (s[i] > s[i+1]) { monno = false; } 
               else { i++; }
            }
            // kiiras
            Console.WriteLine($"{monno}");
        }
`
