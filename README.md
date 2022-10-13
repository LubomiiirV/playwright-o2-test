# playwright-o2-test

dotnet new nunit -n PlaywrightTests

cd PlaywrightTests

dotnet add package Microsoft.Playwright.NUnit

dotnet build

dotnet tool install --global PowerShell

bin/Debug/net6.0(<= dopln aktualnu verziu )/playwright.ps1 install

dotnet test

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

Playwright for .NET 🎭
NuGet version Join Slack

Linux macOS Windows
Chromium 107.0.5304.18 ✅ ✅ ✅
WebKit 16.0 ✅ ✅ ✅
Firefox 105.0.1 ✅ ✅ ✅
Playwright for .NET is the official language port of Playwright, the library to automate Chromium, Firefox and WebKit with a single API. Playwright is built to enable cross-browser web automation that is ever-green, capable, reliable and fast.

Documentation
https://playwright.dev/dotnet/docs/intro

API Reference
https://playwright.dev/dotnet/docs/api/class-playwright

using System.Threading.Tasks;
using Microsoft.Playwright;

class Program
{
public static async Task Main()
{
using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
var page = await browser.NewPageAsync();
await page.GotoAsync("https://playwright.dev/dotnet");
await page.ScreenshotAsync(new() { Path = "screenshot.png" });
}
}
Other languages
More comfortable in another programming language? Playwright is also available in

TypeScript,
Python
Java.
