using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

public class LocalStorage : IDisposable, Hoge
{
    JSRuntime _js;

    public LocalStorage(JSRuntime js)
    {
        this._js = js;
    }

    public async Task SetItem(string key, string value)
    {
        await _js.InvokeVoidAsync("blazorExtentions.SetItem", key, value);
    }

    public async Task<string> GetItem(string key)
    {
        return await _js.InvokeAsync<string>("blazorExtentions.GetItem", key);
    }

    public void Dispose() => throw new NotImplementedException();
}

public interface Hoge{

}