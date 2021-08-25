window.blazorExtensions = {
    TestJs(key) {
        alert(key);
        console.log(key);
    },

    // Web Storageに値を保存するメソッド
    SetItem(key, value) {
        localStorage.setItem(key, value);
    },
    
    // Web Storageから値を取得するメソッド
    GetItem(key) {
        return localStorage.getItem(key);
    }
};
