// https://www.idnet.co.jp/column/page_160.html
using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

public class LocalStorage
{
    IJSRuntime _js;

    public LocalStorage(IJSRuntime js)
    {
        this._js = js;
    }

    public async Task SetItem(string key, string value)
    {
        await _js.InvokeVoidAsync("blazorExtensions.SetItem", key, value);
    }

    public async Task<string> GetItem(string key)
    {
        return await _js.InvokeAsync<string>("blazorExtensions.GetItem", key);
    }

    public async Task RemoveItem(string key){
        await _js.InvokeVoidAsync("blazorExtensions.RemoveItem", key);
    }
}
