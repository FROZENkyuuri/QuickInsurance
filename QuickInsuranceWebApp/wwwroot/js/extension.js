
    function TestJs() {
        console.log("hogehoge");
    }

    // Web Storageに値を保存するメソッド
    function SetItem(key, value) {
        localStorage.setItem(key, value);
    }
    
    // Web Storageから値を取得するメソッド
    function GetItem(key) {
        alert(key);
        return localStorage.getItem(key);
    }
