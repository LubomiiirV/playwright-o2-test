using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;

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
}
