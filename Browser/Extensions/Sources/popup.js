'use strict';

//Nếu bạn là một lập trình viên thực thụ thì hãy xem code thôi chứ đừng 
//Sửa Copyright thàn tên mình như một thằng trẻ trâu =)))
let linkinfo = document.getElementById('link_thong_tin');
let hong_link = document.getElementById('hong_link');
let addbtn = document.getElementById('btnadd');
let tabl = document.getElementById('bodytable');
let show = document.getElementById('showtu');
let btnxoa = document.getElementById('btnxoa');

function loadtable(aru) {
  var tabl2 = document.getElementById('bodytable');
  tabl2.innerHTML = "";
  var table23 = "";
  for (var i = 0; i < aru.length; i++) {
    //<input type="checkbox" name="vehicle" value="Bike">I have a bike<br>
    table23 += '<tr> <td>' + i.toString() + '</td><td> ' + aru[i][0].keyitem + '</td><td>' + aru[i][1].vala + '</td> <td><input type="checkbox" class="del" value="' + i.toString() + '"></td></tr>';
  }
  tabl2.innerHTML = table23;

}
function deleteWords(id) {
  console.log(id);
}
function deleteWord(iden) {
  //ad.splice(2, 1);
  //loadtable()
  //-----------------------------------------//
  var jds = [];
  chrome.storage.sync.get(['mykey'], function (result) {
    if (typeof result.mykey === "undefined") {
    }
    else {
      var dske = result.mykey;
      console.log("------" + dske);
      jds = JSON.parse(dske);
      jds.splice(iden, 1);
      var str = JSON.stringify(jds);
      chrome.storage.sync.set({ 'mykey': str }, function () {
        loadtable(jds);
      });
    }
  });
  //-------------------------------------//
  // chrome.storage.sync.clear(function () {
  //   var error = chrome.runtime.lastError;
  //   if (error) {
  //     console.error(error);
  //   }
  // });
}


show.onclick = function (element) {
  var jds = [];
  chrome.storage.sync.get(['mykey'], function (result) {

    if (typeof result.mykey === "undefined") {
    }
    else {
      var dske = result.mykey;
      jds = JSON.parse(dske);
      loadtable(jds);
    }
  });

}
addbtn.onclick = function (element) {
  var abc = document.getElementById('value_key');
  var key_v1a = document.getElementById('key_abc');
  var key1 = abc.value;
  var value1 = key_v1a.value;
  var canluu = [{ keyitem: key1 }, { vala: value1 }];
  console.log(canluu);
  var jds = [];
  chrome.storage.sync.get(['mykey'], function (result) {

    console.log(result);
    if (typeof result.mykey === "undefined") {
      jds.push(canluu);
      var str = JSON.stringify(jds);
      chrome.storage.sync.set({ 'mykey': str }, function () {
        loadtable(jds);
      });
    }
    else {
      var dske = result.mykey;
      console.log("------" + dske);
      jds = JSON.parse(dske);

      jds.push(canluu);
      console.log(jds);
      var str = JSON.stringify(jds);
      chrome.storage.sync.set({ 'mykey': str }, function () {
        loadtable(jds);
      });
    }
  });



}
linkinfo.onclick = function (element) {
  var url1 = "https://www.facebook.com/nhsonit";
  chrome.tabs.create({ url: url1 });
};

hong_link.onclick = function (element) {
  chrome.tabs.create({ url: "https://www.facebook.com/groups/it2techone/" });
};


btnxoa.onclick = function(element){
  var ar = document.getElementsByClassName('del');
  for(var i = 0; i < ar.length; i++)
  {
    if(ar[i].checked === true)
    {
      deleteWord(ar[i].value);
    }
  }
  
}