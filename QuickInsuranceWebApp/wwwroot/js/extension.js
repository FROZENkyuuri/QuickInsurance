window.blazorExtensions = {
    TestJs: function(key) {
        alert(key);
        console.log(key);
    },

    // Web Storageに値を保存するメソッド
    SetItem: function(key, value) {
        localStorage.setItem(key, value);
    },
    
    // Web Storageから値を取得するメソッド
    GetItem: function(key) {
        return localStorage.getItem(key);
    }
};
