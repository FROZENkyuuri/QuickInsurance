// https://www.idnet.co.jp/column/page_160.html
using System.Threading.Tasks;
using Microsoft.JSInterop;

public sealed class LocalStorage
{
    IJSRuntime _js;

    public LocalStorage(IJSRuntime js)
    {
        this._js = js;
    }

    public async Task SetItem(string key, string value)
    {
        await _js.InvokeVoidAsync($"{JsExtensions.LocalStorage}SetItem", key, value);
    }

    public async Task<string> GetItem(string key)
    {
        return await _js.InvokeAsync<string>($"{JsExtensions.LocalStorage}GetItem", key);
    }

    public async Task RemoveItem(string key){
        await _js.InvokeVoidAsync($"{JsExtensions.LocalStorage}RemoveItem", key);
    }
}