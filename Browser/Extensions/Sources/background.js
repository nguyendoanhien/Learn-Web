'use strict';

//Nếu bạn là một lập trình viên thực thụ thì hãy xem code thôi chứ đừng 
//Sửa Copyright thành tên mình như một thằng trẻ trâu =)))

chrome.runtime.onMessage.addListener(function(request, sender, sendResponse) {
  if (request.method == "getLocalStorage")
    sendResponse({data: localStorage[request.key]});
  else
    sendResponse({}); 
});
chrome.runtime.onInstalled.addListener(function() {
  chrome.storage.sync.set({color: '#3aa757'}, function() {
    console.log('Hello.');
  });
  chrome.declarativeContent.onPageChanged.removeRules(undefined, function() {
    chrome.declarativeContent.onPageChanged.addRules([{
      conditions: [new chrome.declarativeContent.PageStateMatcher({
        pageUrl: {hostEquals: 'www.facebook.com'},
      })],
      actions: [new chrome.declarativeContent.ShowPageAction()]
    }]);
  });
});
