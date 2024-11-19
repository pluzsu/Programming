### Kiválogatásban eldöntés
1. Adott két számsorozatból adjuk meg a közös elemeket
2. Alakítsuk ki az előfeltétel vizsgálatot - a két bemeneti sorozat halmaz kell legyen!   
Mit várunk a kimenetre, ha x: [1, 2, 3, 3, 6] és y: [2, 3, 1, 4]    
kim1: [1, 2, 3, 3] vagy [1, 2, 3]?
  
3. Adott egy számsorozat - soroljuk fel, milyen elemek találhatóak benne. Mindegyiket csak egyszer (sorozat -> halmaz)
4. Adott egy számsorozat - adjuk meg, melyik szám található meg benne és hányszor (sorozat -> multihalmaz)

##
1. Adott egy pozitív egészekből álló sorozat, aminek az indexei egy egyenes mentén a kezdőponttól azonos irányba vett távolságot, értékei tengerszint feletti magasságot jelöli. Keressük meg a lejtőt a legnagyobb magasságkülönbséggel.

pl: 
int[] input = { 9, 6, 5, 5, 4, 8, 10, 12, 11, 8, 9};

Lejtők, irány(\):  
	(9, 6, 5) -> magasság: 4;  
	(5, 4) -> magasság: 1;  
	(12, 11, 8) -> magasság: 4  
Lejtők, irány(/):  
	(4, 8, 10, 12) -> magasság: 8;  
	(8, 9) -> magasság 1  
  
Legnagyobb magasságkülönbség: 8  
indexek (0-val kezdünk): 4, 7  
