# studentu-programa
## 3-4 Laboratoriniai darbai

## 0.1 versija
  Sukurtas studentų įvedimas ranka ir jų išvedimas ant ekrano skaičiuojant bendrą pažymį iš ND pažymių vidurkio arba medianos

## 0.2 versija
  Pridėtas nuskaitymas iš failų. Failas turi būti pavadintas "Studentai.txt" (be kabučių) ir privalo turėti toki formatą:
```
Vardas  Pavardė [ND pažymiai] Egzaminas
[sName] [sSurn] [ND grades]   [eGrade]
...     ...     ...           ...

  Taip pat pridėta galimybė sugeneruoti studento pažymius.

## 0.3 versija
  Pridėtas išimčių valdymas, kad programa veiktų gerai ir nelūžinėtų.

## 0.4 versija
  Pridėta galimybė generuoti įvairaus dydžio studentų failus ir funkcija juos padalinti į du failus pagal reikalavimus (Bendras pažymys >= 5.0 ir Bendras pažymys < 5.0)
  Taip pat pridėta šios funkcijos greičio matavimo galimybė.

# Naudojimosi instrukcija:
## Pagrindinis meniu
### 1 - Įvesti naują studentą
  Įvedamas naujas studentas į atmintį. Prašoma įvesti vardą, pavardę ir egzamino pažymys (sveikas skaičius). Tada programa paklaus, ar sugeneruoti pažymius, ar naudotojas ves juos ranka, jei įvesite 1, bus sugeneruoti pažymiai, jei įvesite kitą skaičių, pažymius reikės vesti pačiam. Įvedus/sugeneravus pažymius naudotojas grąžinamas į pagrindinį meniu.
### 2 - Isvesti studentus ant ekrano
  
### 3 - Nuskaityti studentus is failo
### 4 - Generuoti studentų failą
### 5 - Padalinti studentus is failo
### 6 - Matuoti studentu generavimo ir padalinimo i failus laika

## Greičio testavimo rezultatai
### List<T> konteineris:
```
Failas su 10 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai10 ir nuskriaustukai10) per 0.43 sekundziu
Failas su 100 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai100 ir nuskriaustukai100) per 0.7 sekundziu
Failas su 1000 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai1000 ir nuskriaustukai1000) per 0.35 sekundziu
Failas su 10000 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai10000 ir nuskriaustukai10000) per 0.335 sekundziu
Failas su 100000 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai100000 ir nuskriaustukai100000) per 2.633 sekundziu
```
### LinkedList<T>
```
Failas su 10 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai10 ir nuskriaustukai10) per 0.39 sekundziu
Failas su 100 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai100 ir nuskriaustukai100) per 0.10 sekundziu
Failas su 1000 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai1000 ir nuskriaustukai1000) per 0.34 sekundziu
Failas su 10000 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai10000 ir nuskriaustukai10000) per 0.366 sekundziu
Failas su 100000 studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai100000 ir nuskriaustukai100000) per 2.758 sekundziu
```
