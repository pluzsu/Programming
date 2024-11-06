


[Specifikáció - indexek tárolása](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACnWPwUrDQBCGX2XYU1LWVK8LERREpFrBth5sc9g0GxjSbEt3K21Ki97WB%2FHgc%2FRN8iRlNqYFwYXAzOw3%2F5fdMrNQU8xxKi3ONRPsVgkYFnO9eY%2BDKZZiAGswlVpWvlqYSvRhDYUvQj5ZTjQAgK6d63Moauea5fFVFOmErgdSgLSz2rkXansoIEsbvERa6BObpR6%2BywXU7gNr55oEERRjTKKFqeqvb1%2BSOiR2lPvgePA2egowJpy3cNjVcPgxhAVZyksswrj38Hr4fHy%2Bvxm2dPv3dKSdXZ9cF2cTRy%2FrdtqszZ8kFUUrPgww5HmAoYeJAthDlvo30ogoGpGXelqg%2Fh8tIfkvgtTQZ9qneuXJZpqYjj55zhqfsYdWQKNOl3FmlbGGifGWZdJKJhjjTMtSNdVSmdXMMnG5S3ZH%2BvAmAiICAAA%3D)
```
Be: Tkonyv=(cim:S x szerz:S x psz:N x kpsz:N),
    n∈N, k∈Tkonyv[1..n]
Sa: atl∈R
Ki: db∈N, mik∈N[1..db]
Ef: ∀i∈[1..n]:(k[i].psz≥k[i].kpsz)
Uf: atl=SZUM(i=1..n,k[i].psz)/n és
(db,mik)=KIVÁLOGAT(i=1..n,
        atl>(k[i].psz-k[i].kpsz),i)
/*
(db,y)=KIVÁLOGAT(i=e..u,T(i),f(i))
db,y  ~ db, mik
e..u  ~ 1..n
T(i)  ~ atl>(k[i].psz-k[i].kpsz
f(i)  ~ i

s=SZUM(i=e..u,f(i))
s ~ atl*n
e..u ~ 1..n
f(i) ~ k[i].psz
*/
```

## [Specifikáció2](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACl2Ry07CQBSGX%2BXkrFoyFhHdTOxCE2MMiomAC9supp02mbQdCB0Il5DobnwQFz4Hb9InMTNQEDaTc%2Fv%2B80%2FOGqtJmohMJEyJsUSK9ymFYT6Wy7kPTiJKOoAFVKt0urLRpOC0DwvIbeCScBpKAIB8rmqtd2DQ8TwZEZC11n0zMGAUmCpqrd9M2hMUeGyaBHJR1loPDMLjyHQfMgq1%2FhS11jsh6uRzFYjImxS8%2Fv7ZJ8aAa%2BZHmRX3Bx%2BjF0f4BiFHwG1L2P5We5sOj0kuStfvPb1vv55fH%2B%2BGDdJ8BI7sxb9VcGuWNMKJKO3udsu8RnV5ppl63owMHeGSzBGuHa4ai7Z3KLfaSFCllaqQBmvkTDGkaGzQvacLMHcAdrC4OwfEh4I5Blwfv2Dz7imenOP8FO%2Be4Zc2lxSubMBUQaHr3diEx005N9JBiCxEEmISYoQEJStTpIgEp2k1KxTSziba%2FAFL%2BFatbAIAAA%3D%3D)
```
Be: Tkonyv= (cim:S x szerz:S x pld:N x kpld:N),
    kvt∈Tkonyv[1..n], n∈N
Sa: atl∈R
Ki: db∈N, kim∈S[1..db]
Ef: ∀i∈[1..n]:(kvt[i].pld≥kvt[i].kpld)
Uf: atl=SZUM(i=1..n,kvt[i].pld)/n és
   (db,kim)=KIVÁLOGAT(i=1..n,
     kvt[i].pld-kvt[i].kpld < atl,kvt[i].cim)
/*
(db,y)=KIVÁLOGAT(i=e..u,T(i),f(i))
s=SZUM(i=e..u,f(i))
*/
```
## [Algoritmus](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1X7XLaOBR9lc7NzM5mqmXNVwB3%2BFGSyZYG0o%2BkSVuGH7Ikf6xlGWzhQDJ%2Bqp3pC%2BTFdmSwLFralFL%2BoDlcnXPPvdeSeYCAgg1WrXvSa9Vb9V6ze9LudjtNQODHGUuGFGyx4BxByjgjktEKETFlKdgPkMwvR5a3uFDrgk8DCGY4YUJWm%2FyAUibAdjFPGQK5mjGwIWXzBROEAQLiB5wmTAxpCvYEnM%2Bfh%2FcrkgKCxu2%2Fo%2BZZ9o9izWIerU4FTHNUhZTyxp5K3kzqO0lILFnEhAQEki0l2EAdu29BjuDWbwyd8KynNTSwpWGkuK%2FRlvM6vGqcO4UlzVPKmd73sHTnB7zQigUNZBALsCHo12s1P07T%2Bz%2FDTB4DAiemq6tNYsMtczkCkmSslfGBTkUDW6no9Pd3LpZue%2Bz1loDgtGG9vK4zrygCbb87xe9bnlbWwJby5TxaLq%2Fm0XeVRRzPlBMdWPIZO3%2BPE52gSl%2FzlHIGsSFnDNJuucD9qoFhJifBtDbj9K%2FNMpxx%2BuwPLl88w5Kr6U0WbJBgQfytthqdKyR2hOiS5KjqS2nAaJRhwGDd67mizvO6ktE9L2U0cLBMGEQT6kzt%2FqZOJCiM4dvZ6GYwqwZBA1uKTm%2FZG62C%2BZODpQP1AVTtPPT86wwvP1wksbJ9MrKS8eD%2BrJgujZeaRuA%2BHnZUDUtu97Hk2FsfELkhXapp4GC1MIjsfhhkmMcelkoRYckL1Tefmql1%2B0FqVQ1sqZ6%2B4yv86fzuyT7pQD1p1c5D%2B5R233RefpRdlYTo%2BiLwxoDg1duLj01C3xYt05dWKa%2BBg%2B8pXT9VymLGtXIppoH9ard7PrBn99O%2FjUskR1UFSkWjJAcqpptbOGVnbMxuqgZqYEviPGRJtMLtJwdCB5Z8xk6Dz2jovmMhPT8kowgXA6B5SjmDeJ8K%2FeKtrs3lqMqrTEUD%2B1Vyd7PS59UdBblqnEwWRMZegiNVlgcQOGLm3Kqk7evHL5Ezqddqwr4OY7HKpuoosG8wf%2FwvPa5%2Bpo59df%2F4JWPeFBBkOAmww9WrKACCJI6%2FeY5SP767qcI2FhT6imHKErDVjZkjndcYB%2BIH1MY59zXJbjGDWh%2BsO%2Bweb7z%2BQNoYjp%2BUnqpB4XFSvB%2BvezSBI9e1LMsCBEfq21XvGEeuSzTmWG29cotVx2pauFgRht1uB6brlg8wCb0kXgi6IXYaTkOFqe%2BSmJESYx2Cy5VbrGiLWKyh6NQ%2Fit9IZ0zdN6zqs%2FFMCClcEUJKzG2UGHMpWWO93vpXy%2BqSnnoijhhjLXpiViTP%2FwcPjSvcUg0AAA%3D%3D)

![image](https://github.com/user-attachments/assets/8b9dde56-8e85-4a43-95f7-28337c5b85b3)
![image](https://github.com/user-attachments/assets/f72141ee-7a40-4967-8e05-2a7a87571762)
![image](https://github.com/user-attachments/assets/500e7d77-f4b1-456d-bf3d-55620427b81b)

## Kód
```c#
struct Tkonyv {
            public string cim, szerz;
            public int pld, kpld;
        }
       static void beolvas(out Tkonyv[] kvt) {

            int n = int.Parse(Console.ReadLine());
            kvt=new Tkonyv[n];
            for (int i=0; i < n; i++) {
                kvt[i].cim = Console.ReadLine();
                kvt[i].szerz = Console.ReadLine();
                kvt[i].pld = int.Parse(Console.ReadLine());
                kvt[i].kpld = int.Parse(Console.ReadLine());
            }
        }
        static double atlag(Tkonyv[] minek) {
            int s=0;
            for (int i=0;i<minek.Length;i++) {
                s += minek[i].pld;
            }
            return (double)s/minek.Length;
        }
        static (string[],int) kivalogat(Tkonyv[] m,double atl) {
            string[] kim = new string[m.Length];
            int db = 0;
            for (int i = 0; i < m.Length; i++) {
                if(m[i].pld - m[i].kpld < atl) {
                    kim[db] = m[i].cim;
                    db++;
                }
            }
            return (kim,db);
        }
        static void kiir(string[] mit, int db) {
            for (int i = 0;i<db;i++) {
                Console.Write($"{mit[i]} ");
            }
        }
        static void Main(string[] args) {
            Tkonyv[] kvt;
            beolvas(out kvt);
            double atl = atlag(kvt);
            string[] kim = new string[kvt.Length];
            int db = 0;
            (kim,db) = kivalogat(kvt,atl);
            kiir(kim,db);
        }

```
