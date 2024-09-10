## Specifikáció
<pre>
Be: a ∈ Z, b ∈ Z, c ∈ Z   
Ki: típus ∈ S   
Ef: a < b < c   
Uf: (a + c = 2 * b) -> típus = "számtani" és   
    (a * c = b * b) -> típus = "mértani" és    
    ((a + c ≠ 2 * b) és (a * c ≠ b * b)) -> típus = "egyik sem"   

((a-b)=(b-c)) és típus=”számtani) vagy   
((a/b)=(b/c)) és típus=”mertani) vagy   
Típus=”egyik sem”   
</pre>

**KÉRDÉS:** 
\* és / közötti különbségek!!!

## Algoritmus
![image](https://github.com/user-attachments/assets/cb073a56-b5f9-472b-a2a9-ddab7824ba74)

[link](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1WXU%2FiQBT9K%2BTyomZMCqJAE19w15Vl%2FVhRVmN8mM7cQpd2WtoBBNMfs4%2F7O%2FxjmynMtKwS0sQnbg73nnPuBy2vMApnGHc52GLq%2BwQS9JFJ5DkiQo4J2K9wE9yfX%2FZvj1XscbBzgEBEYxRSFcHd%2BfXyy%2BSxDQRGHucowHapnyABuYgQbBBhGEFK8kTNV6jM%2BVYmPmZKcDJFwRAIsJHn8xhFlydgP8FD7%2BtxrxbdAoHrppB0zmfwnJIc15qFxDI9JJJKDFBIICDxRYINHbQrlFQcUmFZd3PrbOhdtfLuNLCh1PrBm5Oa87hzWiZR8xUqC3ym2%2FIzw2YUXS8Xk2xQtf587P7uJUbOABty3fmsz8S4sdO%2BSdR8hcrPsd%2BRtcFZ7DYy%2B4ZHyxWIy%2BzZc5VQKLgnvVCADXv00Nk%2F3XMO2b5afTzFTkwFG%2FXXvv5fakb3QYppPyX54LVZA5Q7lQ%2BOsufZlWT59ieQVHhK68IZHJ1YnYXRMsCG1vfRy%2Bz8vhbt3KtJ1HyFygKfWU75vf48C5bLi8DP9trptunw293cyBlgQy68egyWD%2Fhrp32TqPkKlZ9j%2F8i%2FeZHRfLCyr3mM%2FZy4zK%2Fq3VnSA3bqHDjbT7Kwlm0naVpPST50bdQA5c5ky0kGb39jfZFmQFrKAOVWukUKhwtvXEkwgDQlkMh4ymQ4jGmgtvMKggaq%2BJJ6AgjMaOxRx1fvOwACcRi%2Be04ko3A%2ByNPWHhR6gZRjvIbSZ7UgP4yzJ%2BjKzxNUXdeyLAsIVNWnq9ZYdV1mMMc6NpGbRU3ryKJZxJC6rSY8r9rrUDYexuFU8DWxU3fqKk19amJkGsMmozpys4g3mIV1Rafe8J9IV5jxO1bGGMt6YYxpVreuMXQ5W2Ht9upby2qxtvqDUUXEBj8pziFN%2FwHc%2B1KdvggAAA%3D%3D)

## Kód
<pre><code>
static void Main(string[] args) {   
             int a, b, c;   
 // beolvasas   
             a = int.Parse(Console.ReadLine());   
             b = int.Parse(Console.ReadLine());   
             c = int.Parse(Console.ReadLine());   
 // feldolgozas   
             if ((a-b)==(b-c)) {   
                Console.WriteLine("szamtani");   
             } else {   
                 if ((a!=0 && b!=0 && c!=0) &&   
                     ((double)a/(double)b==(double)b/(double)c)) {   
                     Console.WriteLine("mertani");   
                 }   
                 else { Console.WriteLine("egyik sem"); }   
             }   
 }   
</code> </pre>
 
