using Microsoft.AspNetCore.Mvc;

/// <summary>
/// オプション演習-01 クエリパラメータを利用する
/// </summary>
[Route("Option01")]
public class Op01Controller : Controller
{
    /// <summary>
    /// 入力値を加算した結果を返す
    /// </summary>
    /// <param name="form">入力値を保持するViewModel</param>
    /// <returns></returns>
    [HttpGet("Calc")]
    public IActionResult Calc([FromQuery] int value1, [FromQuery] int value2, [FromQuery] int opt)
    {
        if (opt == 1)
        {
            var result = value1 + value2;
            return Content($"{value1} + {value2} = {result}");
        }
        else if (opt == 2)//else if だったら条件の指定ができるよ
        {
            var result = value1 - value2;
            return Content($"{value1} - {value2} = {result}");
        }
        else if (opt == 4)
        {
            var result = value1 / value2;
            return Content($"{value1} / {value2} = {result}");
        }
        else if (opt == 5)
        {
            var result = value1 % value2;
            return Content($"{value1} % {value2} = {result}");
        }
        return Content("不明な計算種別です。");

    }
}
