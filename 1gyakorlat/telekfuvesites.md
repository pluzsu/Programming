**Feladat: Üres telket füvesítünk. Adott a telek mérete, és hogy egy zsák fű mekkora területre elég. Adjuk meg, hány zsák fűre van szükségünk!**

## Specifikáció

első ötlet:
<pre>
Be: m1∈N, m2∈N, zs∈N
Ki: db∈N
Ef: m1>0 és m2>0 és zs>0
Uf: db=(m1*m2)/zs
</pre>

gond:
- nincs "tört" zsák -> felfele kellene kerekíteni
- / egész osztás? (egészek közötti osztás - halmazban maradunk!)
- helyesen / helyett div írandó a spec. eszköz esetében, hiszen az az egészosztás
  ([játszd le](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACm2NwWrCQBCGX%2BV3QNitAZO1XgbiQfBU8Oap9rAxGwm4UZy1YCR3X6XP0Tfpk5SNtSDtab7h%2F7%2BZC8nBbeqq3thQ7xtimjuGz76u12UCb26zlTjXx3XzUjPK4r4tqtidpfj8EHjzA63M0piuKoZSSvnsyRuNIVrRyIFU9zVVFvk9G8dM491uz9EE8Ncc5A%2FmgzrKtKaEgpMgxK8XKm2wxEQJNda7Gx2dnHaBOO2S3wJ8xnjuf3rDmPTUCmPaU1kwJv8eMd1b9w3t6xmRPQEAAA%3D%3D)
   a kiértékelést az adott tesztesettel)

[javított kiadás](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACm2NTWrDMBCFr%2FI6EJBaLyyn3Qw4i0BXhe66arKQIzkIKidk1EAdvM9Veo7epCcpcpJCf1bzDe99MweSrV%2BFNqxsCpuOmOaeEc3n8fhYIFan2Uuei92iewgM11y2%2BzZ3ZyU%2B3gWxOkMvszKnTy1DKaWiuY6VxgS9aNRAqceack19yVzY51Rjb9dv2QXw172qf7i%2F5BujNRWUvCQhfj6Qs8kSExXU2ehPtPPy%2BpKIy6H4LiAaxu34NVaM6Ui9MO5Gcg1j%2Bu8RMyyHL6I4G3NBAQAA):
<pre>
Be: m1∈N, m2∈N, zs∈N
Ki: db∈N
Ef: m1>0 és m2>0 és zs>0
Uf: Be: m1∈N, m2∈N, zs∈N
Ki: db∈N
Ef: m1>0 és m2>0 és zs>0
Uf: ((((m1*m2) % zs) =  0) és (db=(m1*m2) div zs)) vagy
    ((((m1*m2) % zs) != 0) és (db=((m1*m2) div zs)+1))
</pre>

## Algoritmus

![image](https://github.com/user-attachments/assets/3f19bd70-1b19-44f0-a4f3-fe427ce28e1e)

[link](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1Uy27bMBD8FXV9SVoeZNXxQ0AONdKH6xQ1YiNtEORAkctIiEQ6FGU3NvTvBWWJlpvmYCQnLka7M7PcFbcQqxXqCYdQFmlKIMcUmUG%2BR6TimEO4heF6fTkqFk82TjiEe4DAkmqUZl8UJ5yjhFDQNEcC5mmJEEKOjwVKhkCAxUnKNcoJzyG8hV%2BP6Xq5kSMgMPs8m93MHvpAwF9N%2B1G2ZEBg%2BPPLb5PMGdyVZJ%2FdOGmV7520%2Fb3gx1CDGUoDBAz%2BMRDCGEMv6xIvC4i3yaEkcLFeyE9XF9%2BdmAMOxFpej20eadRbiPhr1Vs2vVlG%2Fnzq5BxwIHedraPgyugX5aRSS2vfJTZ8rcq3se8MWvuOp5FrER8zmkRYISV5YhIlIYSTk6z7PgtOvUxxb5Ofeu%2FOPd%2FOTRc41lSyeF47nPwzpIr4PynuIsrW0jW2W1v4yo3iUXhee%2BfJql4qN%2FJGzwEHeq0ujtLj0YeulXF%2FjftlG%2BDVbU2TkEdQlgRyowtm1L2mmd2HLUia2aIfNJFAYEV1QqPUviEABLRSz0TzWK2v92m1tkW%2FIeWoa6i8syuRKl09Rzsft9ARwvd9uwodewq7OB0hmMMi%2F8xFoooG%2FkefVhFDKoYDuNu1Nabs4V6rQvKaOAqiwKbZsyFG1mA4YLSJRBXxHvMxsHT21XxDutYdP2NljLGqF8ZYwyqCBkPB2Q4bjXZffX%2FIRmc2QsQe77fvoSz%2FAhxqMB0SBgAA)

## Kód

