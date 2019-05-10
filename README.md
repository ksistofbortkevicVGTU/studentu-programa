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
```
  Taip pat pridėta galimybė sugeneruoti studento pažymius.

## 0.3 versija
  Pridėtas išimčių valdymas, kad programa veiktų gerai ir nelūžinėtų.

## 0.4 versija
  Pridėta galimybė generuoti įvairaus dydžio studentų failus ir funkcija juos padalinti į du failus pagal reikalavimus (Bendras pažymys >= 5.0 ir Bendras pažymys < 5.0)
  Taip pat pridėta šios funkcijos greičio matavimo galimybė.

## 0.5 versija
  Padarytas skaičiavimas su 2 skirtingais konteineriais `List` ir `LinkedList`.

## 1.0 versija
  Sukurtas tvarkingas README.md failas, pridėta naudojimosi instrukcija.

# Naudojimosi instrukcija:
## Pagrindinis meniu
### 1 - Įvesti naują studentą
  Įvedamas naujas studentas į atmintį. Prašoma įvesti vardą, pavardę ir egzamino pažymys (sveikas skaičius). Tada programa paklaus, ar sugeneruoti pažymius, ar naudotojas ves juos ranka, jei įvesite 1, bus sugeneruoti pažymiai, jei įvesite kitą skaičių, pažymius reikės vesti pačiam. Įvedus/sugeneravus pažymius naudotojas grąžinamas į pagrindinį meniu.
### 2 - Isvesti studentus ant ekrano
  Išvesti ant ekrano Atmintyje esančius studentus. Bus paklausta, ar bendrą pažymį skaičiuoti su vidurkiu ar mediana.
### 3 - Nuskaityti studentus is failo
  Nuskaitomi į atmintį failai iš "Studentai.txt" failo.
  Failo formatas turi būti: Vardas, Pavardė, Mažiausiai vienas ND pažymys, Egzamino pažymys
### 4 - Generuoti studentų failą
  Sugeneruojamas studentų failas, su atsitiktiniais bendrais įvertinimais. Bus paklausta, kiek studentų reikia sugeneruoti faile, tada bus sugeneruotas failas "kursiokaiXXX.txt", kur XXX:jūsų įvestas skaičius.
### 5 - Padalinti studentus is failo
  Padalinti "kursiokaiXXX.txt" failą į du failus su studentais turinčiais bendrą pažymį didesni ir mažesnį už 5. Bus paklausta, kiek studentų yra faile. Tai bus panaudota failo nuskaitymui.
### 6 - Matuoti studentu generavimo ir padalinimo i failus laika
  Atliekamos 4 ir 5 funkcijos, matuojamas ir išvedamas, kiek užtrūko laikas jas atlikti.

## Greičio testavimo rezultatai
### List<T>

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
