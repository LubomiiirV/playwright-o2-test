# playwright-o2-test

dotnet new nunit -n PlaywrightTests
cd PlaywrightTests
dotnet add package Microsoft.Playwright.NUnit
dotnet build
dotnet tool install --global PowerShell
pwsh bin/Debug/netX/playwright.ps1 install

Test Generator:

    npx playwright codegen playwright.dev

Pripravil som nasledujucu ulohu, ktora je podmnozinou realnej prace pre danu poziciu.

Rozbehaj si playwright vo visual studio

Vytvorenie test (BE validacie nie su nutne) na produkcnej o2 stranke pre nakup pausalu s telefonom (objednavku nedokoncovat)

Biznis process je nasledovny:
Chod na o2.sk
Navigovat sa cez nasledovne: Nasa Ponuka -> telefony a zariadenia -> prejst na vsetky telefony
Vyberte akykolvek telefon na sklade a kupte telefon s programom
Kliknite v dalsom kroku na dokoncit objednavku – vyskoci dialogove okno, kde zvolite preskocit prihlasenie
Vyplnte vsetky povinne polia a oznacte povinne suhlasy a kliknite potvrdit
Tu test skonci, nakolko v dalsom kroku by ste potvrdili objednavku finalne, co nie je nutne

Bonusova Uloha:
Nagivovat sa cez o2.sk -> nasa ponuka -> pre domacnost -> prejst na internet na doma. Na tejto stranke overit dostupnost internet una doma pre lubovolnu adresu.

Testy prosim poslite nahrate na video + kod v C#.

Bonusove body:
validacie na FE
validacie na BE

pouzitie features ako screenshot obrazka alebo nahratie videa priamo z IDE

vyhladanie konkretneho telefonu v kombinacii s pausalom

implementacia page object modelu
