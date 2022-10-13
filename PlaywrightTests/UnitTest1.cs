using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{

  [SetUp]
  public async Task Setup()
  {
    await Page.GotoAsync("https://www.o2.sk");

  }
  [Test]
  public async Task ChodNaO2Sk()
  {

    // Expect page to have URL.
    await Expect(Page).ToHaveURLAsync(new Regex("https://www.o2.sk"));
    await Page.ScreenshotAsync(new()
    {
      Path = "screenshot.png",
      FullPage = true,
    });


  }

  [Test]
  public async Task NavigovatSaCezNasledovneNasaPonukaTelefonyAzariadeniaPrejstNaVsetkyTelefony()
  {
    // find and hover Nasa ponuka
    var handle = Page.Locator("text='Naša ponuka'");
    await handle.HoverAsync();

    //  click Telefony a zariadenia
    await Page.GetByText("Telefóny a zariadenia").ClickAsync();
    await Page.WaitForTimeoutAsync(1500);

    await Page.ScreenshotAsync(new()
    {
      Path = "screenshot1.png",
      FullPage = true,
    });

    // click Mobilne telefony
    await Page.GetByText("Mobilné telefóny").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/produkty/telefony");
    await Page.WaitForTimeoutAsync(1500);

    await Page.ScreenshotAsync(new()
    {
      Path = "screenshot2.png",
      FullPage = true,

    });

    // choose a device
    await Page.GetByText("Apple iPhone 14 256GB Fialový").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/produkt/apple-iphone-14-256gb-fialovy");
    await Page.WaitForTimeoutAsync(1500);

    await Page.ScreenshotAsync(new()
    {
      Path = "screenshot3.png",
      FullPage = true,

    });

  }
  //   [Test]
  //   public async Task VyberteAkykolvekTelefonNaSkladeAKupteTelefonSProgramom()
  //   {
  //     //
  //     await Page
  //       .Locator('o2-button:has-text("Kúpiť za plnú sumu")')
  //       .GetByRole('button')
  //       .ClickAsync();
  //     await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/kosik");
  //   }

  //   [Test]
  //    public async Task VyplnteVsetkyPovinnePoliaAOznactePovinneSuhlasyAKliknitePotvrdit.TuTestSkonciNakolkoVDalsomKrokuByStePotvrdiliObjednavkuFinalneCoNieJeNutne() 
  //    {}
  //     await page.getByRole("button", { name: "súkromná osoba" }).click();
  //     await page.locator('a:has-text("súkromná osoba")').click();
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.firstName"]')
  //       .click();
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.firstName"]')
  //       .fill("Ľubomír");
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.lastName"]')
  //       .click();
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.lastName"]')
  //       .fill("Václavik");
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.lastName"]')
  //       .press("Tab");
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.contactPhone"]')
  //       .click();
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.contactPhone"]')
  //       .fill("0948528362");
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.email"]')
  //       .click();
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.email"]')
  //       .fill("vaclaviklubomir@gmail.com");
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.address\\.street"]')
  //       .click();
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.address\\.street"]')
  //       .fill("Zuzany");
  //     await page
  //       .getByRole("option", {
  //         name: "Zuzany Chalupovej, Bratislava-Petržalka, 851 07",
  //       })
  //       .click();
  //     await page
  //       .locator(
  //         'input[name="customerInfo\\.primaryContact\\.address\\.houseNumber"]'
  //       )
  //       .click();
  //     await page
  //       .locator(
  //         'input[name="customerInfo\\.primaryContact\\.address\\.houseNumber"]'
  //       )
  //       .fill("10B");
  //     await page
  //       .locator('input[name="customerInfo\\.primaryContact\\.address\\.city"]')
  //       .click();
  //     await page
  //       .locator(
  //         'input[name="customerInfo\\.primaryContact\\.address\\.houseNumber"]'
  //       )
  //       .click();
  //     await page
  //       .getByLabel("Súhlasím so všetkými nižšie uvedenými možnosťami.")
  //       .check();
  //   });
}
