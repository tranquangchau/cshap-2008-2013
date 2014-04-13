/* $Header: c:/cvs/repo/mosh/quiz/quiz.pl,v 1.64 2013-11-30 07:44:56 a Exp 3040 */
/* AUTHOR: (C) moshahmed */
function evaluate_quiz_qn(quiz_number,quiz_size,debug,gui_radio) {
  var i, rights = 0;
  for(i=0; i<quiz_size; i++) {
    var ans = "", correct=0;
    var qid = 'q_qn_'+(i+1);
    if (gui_radio) {
      var dqid = document.getElementsByName(qid);
      var tried = 0;
      for (var k=0; k < dqid.length; k++) {
        if (dqid[k].value)
          ans = "answer is " + (k+1);
        if (dqid[k].checked)
          tried=1;
        if (dqid[k].checked && dqid[k].value)
          correct = 1;
      }
      if (!tried) {
        ans = '';
      } else {
        if (correct) ans = 'correct, ' + ans;
        else         ans = 'wrong, ' + ans;
        for (var k=0; k < dqid.length; k++) {
          dqid[k].setAttribute('disabled',1);
        }
      }
    } else { /* dropdown */
      var dqid = document.getElementById(qid);
      var ansidx = dqid.getAttribute('data-ansidx');
      correct = dqid.selectedIndex == ansidx;
      var tried = !dqid.value.match('^-+$');
      if(tried){
        ans = dqid.getAttribute('data-ansval');
        if(correct) {
          ans = 'correct, it is ' + ans;
        } else {
          ans = 'wrong, it is ' + ans;
        }
        dqid.setAttribute('disabled',1);
      }
    }
    /* if(debug) { console.log(dqid); } */
    rights += correct;
    var tid = 't_qn_'+(i+1)+'_3';
    var tqid = document.getElementById(tid);
    tqid.innerHTML = color_it(correct,ans);
  }
  var deid = document.getElementById('evaluate_quiz_qn');
  if ( deid.value.match('evaluated') ) {
    alert ('Retry: quiz 1: ' + rights + ' correct of ' + i);
  }else{
    alert ('quiz 1: ' + rights + ' correct of ' + i);
    deid.value = 'evaluated quiz 1, ' + rights + ' / ' + quiz_size;
  }
}
function evaluate_question(i,debug,gui_radio){
  var correct, ans, tried;
  if (gui_radio) {
    var qid = 'q_qn_'+(i+1);
    var dqid = document.getElementsByName(qid);
    for (var k=0; k < dqid.length; k++) {
      if (dqid[k].value)
        ans = "answer is " + (k+1);
      if (dqid[k].checked && dqid[k].value)
        correct=1;
      if (dqid[k].checked)
        tried=1;
    } 
    if (!tried) {
      ans = '';
    } else {
      if (correct) ans = 'correct, ' + ans;
      else         ans = 'wrong, ' + ans;
      for (var k=0; k < dqid.length; k++) {
        dqid[k].setAttribute('disabled',1);
      }
    }
  } else { /* dropdown */
    var qid = 'q_qn_'+(i+1);
    var dqid = document.getElementById(qid);
    var ansidx = dqid.getAttribute('data-ansidx');
    ans = dqid.getAttribute('data-ansval');
    correct = dqid.selectedIndex == ansidx;
    var nottried = dqid.value.match('^-+$');
    if (nottried) {
      ans = dqid.value;
    } else {
      dqid.setAttribute('disabled',1);
      if(correct) {
        ans = 'correct, it is ' + ans;
      } else {
        ans = 'wrong, it is ' + ans;
      }
    }
  }
  /* if(debug) { console.log(dqid); } */
  var tid = 't_qn_'+(i+1)+'_3';
  var tqid = document.getElementById(tid);
  tqid.innerHTML = color_it(correct,ans);
} 
var colors = [
    '<div class=wrong   >',
    '<div class=correct >'
];
function color_it(correct,text) {
  return colors[correct?1:0] + text + '</div>';
}
