## Specifikáció
Be: x ∈ Z, y ∈ Z, z ∈ Z   
Ki: típus ∈ S   
Ef: x < y < z   
Uf: (x + z = 2 * y) -> típus = "számtani" és   
    (x * z = y * y) -> típus = "mértani" és    
    ((x + z ≠ 2 * y) és (x * z ≠ y * y)) -> típus = "egyik sem"   

((x-y)=(y-z)) és típus=”számtani) vagy   
((x/y)=(y/z)) és típus=”mertani) vagy   
Típus=”egyik sem”   


**KÉRDÉS:** 
\* és / közötti különbségek!!!

## Kód
> static void Main(string[] args) {
>             int a, b, c;
> // beolvasas
>             a = int.Parse(Console.ReadLine());
>             b = int.Parse(Console.ReadLine());
>             c = int.Parse(Console.ReadLine());
>  
> // feldolgozas
>             if ((a-b)==(b-c)) {
>                Console.WriteLine("szamtani");
>             } else {
>                 if ((a!=0 && b!=0 && c!=0) &&
>                     ((double)a/(double)b==(double)b/(double)c)) {
>                     Console.WriteLine("mertani");
>                 }
>                 else { Console.WriteLine("egyik sem"); }
>             }
> }
