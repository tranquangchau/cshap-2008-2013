//See lines 10 & 94 for change made for Ajax compatibility 
var ch, cur = '', last = '', isArrow = false, lastLen = -1, tmp, sn = false, keyElt = false, hostnm = '', appnm = '', protocol = '', lgkform = false, rgn = false, rel = false;
var offY = 0, offX = 0, inp = false, lgkAcBox;

var CrossJax=new CrossJaxObject();

function lgkOnLoad() { //{{{

  hostnm = window.location.hostname;
  //typeof added for Ajax support. server var defined in ajax call, if present, use instead of window.location.hostname
  if(typeof server !== 'undefined' && server != null) hostnm = 'ss' + server + '.fusionbot.com'; 
  appnm = '/b/ac';
  protocol = 'http';
  if(typeof proto !== 'undefined' && proto != null) protocol = proto; //manually force ssl for clients with SSL cert on FB Box 
  try { hostnm = clhostnm; if(clappnm !=0) { appnm = clappnm; protocol = 'https'; } } //clappnm (server side page calling autocomplete behind the scenes on ssl)
  catch(e) { }

  elts = new Array('k','keys');

  for(elt in elts) {
    x = document.getElementsByName(elts[elt]);
    for(i = 0 ; i < x.length ; ++i) {
      inp = x.item(i);
      inp.onkeydown = keyd;
      inp.onkeyup = keyup;
      inp.userFocus = null;
      if(typeof inp.onfocus != undefined && typeof inp.onfocus != null) { // preserve user defined onfocus
        u = String(inp.onfocus);
       // if(u.indexOf("onfocus") != -1)
        //{
          u = u.replace(/this\./g,"inp.");
          //inp.userFocus = u.replace(/onfocus/g,"lgkfocus");
          inp.userFocus = u.replace(/function[\s]+[^\s]+([\s]+)?\(/g, "function lgkfocus(");
        //}
      } 
      inp.onfocus = acfocus;
      inp.setAttribute("autocomplete", "off");
    }
  }

 updateInp(); 

 // Create and position autocomplete div
 var div = document.createElement('div');
 div.setAttribute('id','lgk-ac');
 div.setAttribute('name','lgk-ac');
 div.setAttribute('style','z-index:1000; position:absolute; display:none; top:'+offY+'px; left:'+offX+'px;');
 document.getElementsByTagName("body")[0].appendChild(div);
 lgkAcBox = document.getElementById('lgk-ac');

 // Create <style> for IE
 var st = document.createElement('style');
 st.setAttribute('type','text/css');
 if(st.styleSheet) {
   st.styleSheet.cssText = '#lgk-ac { position:absolute; top:'+offY+'px; left:'+offX+'px; }';
   document.getElementsByTagName("body")[0].appendChild(st);
 }
} //}}}
function updateInp() { //{{{
  // Enough space to show box?
  if(inp.type != undefined) {

    offY = getTop(inp) + inp.offsetHeight;
    offX = getLeft(inp);

    if(document.body.clientWidth - offX < 250)
      offX = document.body.clientWidth - 250;
  
    // find our parent <FORM>
    iter = inp;
    lgkform = false;
    while(iter && lgkform == false) {
      if(iter.nodeName == 'FORM')
        lgkform = iter;
      else if(iter.previousSibling) {
        prev = iter.previousSibling;
        while(prev && lgkform == false) {
          if(prev.nodeName == 'FORM')
            lgkform = prev;
          prev = prev.previousSibling;
        }
      }
      iter = iter.parentNode;
    }
  }

  //typeof added for Ajax support. sitenbr var defined in ajax call, if present, use instead of sn, which is not present on their page 
  if(typeof sitenbr !== 'undefined' && sitenbr != null)
    sn = sitenbr;
  else {
    // Find Sitenbr
    elts = new Array('sn','sitenbr');
    sn = false;
    for(elt in elts) {
      x = document.getElementsByName(elts[elt]);
      for(i = 0 ; i < x.length && sn == false ; ++i)
        sn = x.item(i).value
    }

    // Find Region
    rgn = false;
    x = document.getElementsByName('rgn');
    for(i = 0 ; i < x.length && rgn == false; ++i)
      rgn = x.item(i).value;

    // Find Rel
    rel = false;
    elts = new Array('rel','related');
    for(elt in elts) {
      x = document.getElementsByName(elts[elt]);
      for(i = 0 ; i < x.length && rel == false; ++i) {
        tmp = x.item(i);
        rel = tmp.options[tmp.selectedIndex].innerHTML;
      }
    }
  }
} //}}}
function keyd(e) { //{{{
  if(!e) var e = window.event;
  if(e.keyCode) ch = e.keyCode; // IE
  else if(e.which) ch = e.which; // Firefox/Opera/EveryoneElse
  
  if(ch == 8) // Backspace
    cur = last = '';
  else if(ch == 27) // Escape
    lgkAcBox.style.display = 'none';
  else if(ch == 38) // Arrow Up
  {
    isArrow = true;
    if(lgkAcBox.style.display == 'none') return;
    if(cur != '')
    {
      if(Number(cur.substring(4)) > 0)
        setCurrent('lgk_' + (Number(cur.substring(4)) - 1).toString(), true);
    }
  }
  else if(ch == 40) // Arrow Down
  {
    isArrow = true;
    if(lgkAcBox.style.display == 'none') return;
    if(cur == '')
      cur = 'lgk_0';
    else
    {
      tmp = 'lgk_' + (Number(cur.substring(4)) + 1).toString();
      if(isID(tmp))
        cur = tmp;
      else
        cur = 'lgk_0';
    }
    setCurrent(cur, true);
  }
} //}}}
function keyup(e) { // {{{
  if(!e) var e = window.event;
  if(e.srcElement) { key = e.srcElement.value; keyElt = e.srcElement; }
  else if(e.target) { key = e.target.value; keyElt = e.target; }

  if(ch == 27 || ch == 13) { return; } //escape
  if(isArrow == true) { isArrow = false; return; }
  if(key.length)
  {
    if(key.length != lastLen)
    {
      //CrossJax.httpreq(protocol+'://'+hostnm+appnm+'?js=1&sn='+sn+'&k='+key, crossjax_callback);
      qs = 'js=1&sn='+sn+'&k='+key;
      if(rgn != false) qs += '&rgn='+rgn;
      if(rel != false) qs += '&rel='+rel;
      CrossJax.httpreq(protocol+'://'+hostnm+appnm+'?'+qs, crossjax_callback);
      lastLen = key.length;
      cur = last = '';
    }
  }
  else
   lgkAcBox.style.display = 'none';
} //}}}
function acfocus(e) { //{{{
  if(this.toString().indexOf("window") > -1)
    return;
  inp = this;
  lgkAcBox.innerHTML = '';
  updateInp();
  lgkAcBox.style.top = offY+'px';
  lgkAcBox.style.left = offX+'px';
  if(inp.userFocus != null && inp.userFocus != 'undefined' && inp.userFocus != 'null') {
    eval(inp.userFocus);
    lgkfocus(e);
  }
} //}}}
function setCurrent(id,upK) { //{{{
  cur = id;
  document.getElementById(cur).style.backgroundColor = "#ddd";
  if(upK)
    keyElt.value = document.getElementById(cur).name;
  if(last != '' && last != cur)
    document.getElementById(last).style.backgroundColor = "transparent";
  last = cur;
} //}}}
function subm(t) { //{{{
  setCurrent(t.id, true); 
  lgkAcBox.style.display = 'none';
  lgkform.submit();
} //}}}
function getTop(elt) { //{{{
  for(ret = 0 ; elt ; elt = elt.offsetParent)
		ret += elt.offsetTop;
	return ret;
} //}}}
function getLeft(elt) { //{{{
  for(ret = 0 ; elt ; elt = elt.offsetParent) {
		ret += elt.offsetLeft;
  }
	return ret;
} //}}}
function over(t) { setCurrent(t.id, false); }
function isID(id) { return (document.getElementById(id) == null) ? false : true; }
function setStatus(s) { document.getElementById('status').innerHTML += ',' + s; }

// Creates a <script src='fusionbot.com'> call that
// circumvents the inability of XMLHttpRequest to make cross-domain calls
function crossjax_callback() { //{{{
  if(CrossJax.success) {
    if(CrossJax.responseText.length)
    {
      if(lgkAcBox.style.display == 'none') {
        lgkAcBox.style.display = 'block';
      }
      if(lgkAcBox.style.visibility == 'hidden') {
        lgkAcBox.style.visibility = 'visible';
      }

      txt = CrossJax.responseText;
      //add global variable (ac_clean = true) to template if we want to strip out out of range characters
      if(typeof ac_clean !== 'undefined' && ac_clean != null)
        txt = txt.replace(/[^\u0000-\u007E]/g, "");
      lgkAcBox.innerHTML=txt;

    }
    else
      lgkAcBox.style.display = 'none';
  }
} //}}}
function crossjax_complete(responseText) { //{{{
  // Contents of script will be a call to this function
  if(CrossJax.callback) {
    CrossJax.responseText=responseText;
    CrossJax.success=true;
    CrossJax.callback();
  }
  CrossJax.remove('crossjaxrm');
  CrossJax.busy = false;
} //}}}
function CrossJaxObject() { //{{{
this.success = // Status
this.busy =    // Mutex
this.responseText = // Response Text
this.callback = false; // User Supplied Callback
this.remove=function(id) { setTimeout(function() { document.getElementsByTagName("body")[0].removeChild(document.getElementById(id)); }, 0); }
this.append=function(src,id) { // Create <script> and append, this calls our servers
 var e = document.createElement('script');
 e.setAttribute('type','text/javascript');
 e.setAttribute('id',id);
 e.setAttribute('src',src);
 document.getElementsByTagName("body")[0].appendChild(e);
}
this.httpreq=function(url,callback) {
 if(this.busy) return;
 this.busy=true;
 this.success=false;
 this.callback=callback;
 this.append(url,'crossjaxrm');
}

} //}}}

addDOMLoadEvent = (function(){ //{{{
  // create event function stack
  var load_events = [],
  load_timer,
  script,
  done,
  exec,
  old_onload,
  init = function () {
    done = true;

    // kill the timer
    clearInterval(load_timer);

    // execute each function in the stack in the order they were added
    while (exec = load_events.shift())
      exec();

    if (script) script.onreadystatechange = '';
  };

  return function (func) {
    // if the init function was already ran, just run this function now and stop
    if (done) return func();

    if (!load_events[0]) {
      // Mozilla/Opera9
      if (document.addEventListener)
        document.addEventListener("DOMContentLoaded", init, false);

      // IE Conditional Comments
      /*@cc_on @*/
      /*@if (@_win32)
        document.write("<script id=__ie_onload defer src=//0><\/scr"+"ipt>");
        script = document.getElementById("__ie_onload");
        script.onreadystatechange = function() {
          if (this.readyState == "complete")
            init(); // call the onload handler
        };
      /*@end @*/

      // Webkit
      if (/WebKit/i.test(navigator.userAgent)) { // sniff
        load_timer = setInterval(function() {
          if (/loaded|complete/.test(document.readyState))
            init(); // call the onload handler
        }, 10);
      }

      // Others
      old_onload = window.onload;
      window.onload = function() {
        init();
        if (old_onload) old_onload();
      };
    }
    load_events.push(func);
  }
})(); //}}}

try {
  if(needsDom == 1)
    addDOMLoadEvent(lgkOnLoad);
}
catch(e) { }

