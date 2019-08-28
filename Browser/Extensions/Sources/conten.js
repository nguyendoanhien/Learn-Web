
//Nếu bạn là một lập trình viên thực thụ thì hãy xem code thôi chứ đừng 
//Sửa Copyright thàn tên mình như một thằng trẻ trâu =)))
function getRndInteger(min, max) {
    return Math.floor(Math.random() * (max - min + 1) ) + min;
}
function st() {

    setTimeout(function () {
        //    key = "nguyen";
        //     chrome.storage.local.get(['key'], function(result) {
        //         console.log('Value currently is ' + result.key);
        //       });
        
        var dem = 0;
        chrome.storage.sync.get(['mykey'], function (result) {
        a = document.getElementsByTagName("p");
        if (a.length > 0) {
            if(a.length > 4)
            {
                for(var i = a.length - 1; i >= 0 ; i --)
                {
                    if (a[i].innerText.length > 2)
                    {
                            var tex = a[i].innerText;
                            if (tex.indexOf("$") < 0) {
                                //var rand = result.mykey[Math.floor(Math.random() * result.mykey.length)];
                                tex = tex + "_$_";
                                var avbc = JSON.parse(result.mykey);
                                var sorand = getRndInteger(0, avbc.length - 1);
                                var inde = getRndInteger(0, tex.length - 1);
                                var htm = "<a class='btn  btn-primary'> " + "<b style='color: red;' title='"+avbc[sorand][0].keyitem +"'>"+" "+avbc[sorand][1].vala+" </b> "+ "  </a>";
                                if(tex[inde]==" ")
                                {
                                    var value123 = " "+htm+" ";
                                    var stm = tex.substr(0, inde) + value123 + tex.substr(inde);
                                    a[i].innerHTML = stm;
                                }
                                else if(inde < tex.length - 1 )
                                {
                                    for(var j = inde; j < tex.length ; j++)
                                    {
                                        if(tex[j]==" ")
                                        {
                                            var value123 = " "+htm+" ";
                                            var stm = tex.substr(0, j) + value123 + tex.substr(j);
                                            a[i].innerHTML = stm;
                                        }
                                    }
                                }
                                else
                                {
                                            var value123 = " "+htm+" ";
                                            var stm = tex + value123;
                                            a[i].innerHTML = stm;
                                }
                                
                                dem ++;
                                if(dem >= Math.random()*10 + 3 )
                                {
                                    break;
                                }
                            }
                    }
                }
            }
          
        }
        });

       
        st();
    }, 3100);
}
st();

