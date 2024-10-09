https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACqtWKi5ITc5My0xOLMnMz1OyUnJKtVLSUSpJLS4pVrKKrlZKSSxJVLJSUtJRykvMTYWwilKLS3NKlKyMamNrAdhsq6pCAAAA#

/* számsorozat - monoton növekedő-e */
Be: n∈N, s∈Z[1..n]
Ki: monno∈L
Ef: n>=2
Uf: monno=nem VAN(i=1..n-1,s[i]>s[i+1])
/* eldöntés 
Uf: van=VAN(i=e..u,T(i)) 
van  ~ nem monno
e..u ~ 1..n-1
T(i) ~ s[i]>s[i+1]*/
