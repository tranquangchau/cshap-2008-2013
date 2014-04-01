/**************************************
 * THEME NAME: computer-scientist
 *
 * Files included in this sheet:
 *
 *   computer-scientist/styles_color.css
 **************************************/

/***** computer-scientist/styles_color.css start *****/

/*******************************************************************
 styles_color.css
  
 This CSS file contains all color definitions like 
 background-color, font-color, border-color etc.

 Styles are organised into the following sections:

  core
  header
  footer

  admin
  blocks
  calendar
  course
  doc
  login
  message
  tabs
  user

  various modules

*******************************************************************/

/***
 ***  Core
 ***/

a:link,
a:visited {
  color:#0B7AF6;
  text-decoration:underline;
}

a.dimmed:link,
a.dimmed:visited {
  color:#0B7AF6;
}

a:hover {
  color:#0B7AF6;
  text-decoration:none;
}

a.autolink:link,
a.autolink:visited {
  color:#000000;
}

a.autolink.glossary:hover {
  cursor: help;
}
.searchform a{
	font-size:11px;
}
.info bold a{
	font-size:11px;
}
.lastpost a {
	font-size:11px;
}
.post {
	font-size:11px;
}
.post .info{
	font-size:11px;
}
.activitydate {
	font-size:11px;
}
.activityhead {
	font-size:11px;
}
.subject {
	font-size:13px;
	font-family:Tahoma;
}

img.userpicture,
img.grouppicture {
  border-color:#000
}

.block_online_users .listentry img {
  border:#888
}

body {
  background: #FFFFFF url(pix/bg.gif);
  color: #000000;
  font-family:Tahoma;
  padding:0px;
  margin:0px;
}
#page {
	width:994px;
	margin:0px auto;
  	background: #FFFFFF url(pix/bg_page.gif) repeat-y;
}
#header {
	width:990px;
	margin:0px auto;
	height:68px;
	background:url(pix/top.jpg) top repeat-x;
}
.heightcontainer .header {
	background: #C0C0C0;
}
#header-home {
	width:990px;
	margin:0px auto;
	height:68px;
	background:url(pix/top.jpg) top repeat-x;
}
.headermenu {
	padding:10px 25px 0px 0px;
}
#banner {
	height:97px;
	background:url(pix/banner.jpg) top no-repeat;
	padding-left:34px;
	padding-top:30px;
}
.headermain {
	height:68px;
}

#banner h1.headermain {
	color: #FFFFFF;
}

#content {
padding:0px 10px 10px 10px;
	margin:0px 5px 0px 5px;
}
div.header {
	background:#39A7D7 url(pix/h2.png) top repeat-x;
	padding:5px 5px 0px 5px;
	margin:0px;
	border: none;
}
div.title {
	padding:5px 5px 0px 5px;
	color:#FFFFFF;
}
th.header,
td.header{
  background-color:#C0C0C0;
}

.navbar {
  height:46px;
  background:url(pix/navbar.jpg) top no-repeat;
  padding-left:25px;
  padding-right:25px;
  padding-top:10px;
  padding-bottom:0px;
  border:0px;
}
.coursesearchbox {
	color:#000000;
	font-size:11px;
	font-family:Tahoma;
	font-weight:bold;
}
table.formtable tbody th {
  background-color: transparent;
}

.highlight {
  background-color:#AAFFAA;
}

.highlight2 {
  color:#AA0000;/* highlight missing terms in forum search */
}

/* Alternate rows even */
.r0 {  
	font-size:11px;
}

/* Alternate rows odd */
.r1 {  
	font-size:11px;
}

/* notification messages (can be good or bad) */
.notifyproblem {
  color:#660000;
}
.notifysuccess {
  color:#006600;
}

#admin-auth_config .required {
  background-color:#DDDDDD;
}

.generalbox .generalboxcontent {
  border-color:#C0C0C0;
  background-color:#DDDDDD;
}

.informationbox {
  border-color:#C0C0C0;
}

.feedbackbox {
  border-color: #888888;
}
.feedbackby {
  background-color:#BBBBBB;
}

.noticebox {
  border-color:#C0C0C0;
}

.errorbox {
  color:#ffffff;
  border-color:#660000;
  background-color:#990000;
}

.errorboxcontent {
  background-color:#FFBBBB;
}

.tabledivider {
  border-color:#C0C0C0;
}

.sitetopiccontent {
  border-color:#DDDDDD;
  background-color:#FFFFFF;
  border-color:#C0C0C0;
}

.dimmed_text {
  color:#AAAAAA;
}

.teacheronly {
  color:#990000;
}

.unread {
  background-color: #FFD991;
} 

.censoredtext {
  color:#000000;
  background-color:#000000;
}


/* kept for backward compatibility with some non-standard modules
   which use these classes for various things */
.generaltab, .generaltabinactive {
  background-color:#BBBBBB;
}
.generaltabselected {
  background-color:#DDDDDD;
}
.generaltabinactive {
  color:#CCCCCC;
}



/***
 *** Header
 ***/
.breadcrumb {
  height:35px;
  color: #000000;
  font-weight:normal;
  font-size:11px;
}
.breadcrumb .sep {
  color: #000000;
  font-weight:normal;
  margin:5px;
}
.first a:link {
	color:#0B7AF6;
	font-size:11px;
	font-weight: normal;
}
.first a:visited {
	color:#0B7AF6;
	font-size:11px;
	font-weight: normal;
}
.first a:hover {
	color:#0B7AF6;
	font-size:11px;
	font-weight: normal;
	text-transform:none;
}
.first .accesshide {
	color:#FFFFFF;
	font-size:11px;
	font-weight: normal;
}
/***
 *** Footer
 ***/
#footer {
	height:80px;
	background: #B1BAC1 url(pix/footer.gif) top repeat-x;
	padding-top:4px;
	margin:0px 5px 0px 5px;
	color:#FFFFFF;
}
#footer a, #footer a:hover{
	font-size: 11px;
}

.homelink a:link,
.homelink a:hover,
.homelink a:visited {
  background-color: none;
  color:#0B7AF6;
  text-decoration:underline;
  font-size:11px;
  border:none;
  display: inline;
}


/***
 *** Admin
 ***/

.admin .informationbox {
  border-color:#BBBBBB;
  background-color:#FFFFFF;
}

body#admin-index .c0 {
  background-color: #FAFAFA;
}

body#admin-blocks table#blocks .r0,
body#admin-blocks table#incompatible .r0 {
  background-color: #f0f0f0;
}

body#admin-blocks table#blocks .r1,
body#admin-blocks table#incompatible .r1 {
  background-color: #fafafa;
}

body#admin-blocks table#incompatible td.c0 {
  color: #ff0000;
}

table.flexible  .r0 {
  background-color: #f0f0f0;
}

table.flexible .r1 {
  background-color: #fafafa;
}

body#admin-lang .generalbox {
  border-color:#C0C0C0;
  background-color:#FFFFFF;
}

#adminsettings {
  background-color: #FFFFFF;
  border-color: #C0C0C0;
  color: #000000;
}

#adminsettings fieldset {
  background-color: #FFFFFF;
  border-color: #C0C0C0;
  color: #000000;
}

#adminsettings .form-shortname {
  color: #888888;
}

.block_admin_tree.sideblock .link.current {
  background-color:#DDDDDD;
  color: #FFFFFF;
}

/***
 *** Blocks
 ***/
.block_activity_modules .sideblock {
	border:1px solid #FF0000;
}

.sideblock .content {
  background-color:#DDDDDD;
  border:1px solid #C0C0C0;
}

.sideblock .content hr {
  border-top-color:#999999;
}

.sideblock .header .hide-show img.hide-show-image {
  background: url('pix/t/switch_minus.gif') no-repeat bottom;
}

.sideblock.hidden .header .hide-show img.hide-show-image {
  background: url('pix/t/switch_plus.gif') no-repeat bottom;
}

.blockconfigtable {
  background-color:#FFFFFF;
  border-left:1px solid;
  border-right:1px solid;
  border-bottom:1px solid;
  border-color:#AAAAAA;
}


/***
 *** Blogs
 ***/

.blogpost.blogdraft .content {
  background-color:#FFFFFF;
}

.block_blog_tags .official {
  color: #0000FF;
}

.block_blog_tags .personal {
  color: #0066CC;
}


/***
 *** Calendar
 ***/

#calendar .maincalendar,
#calendar .sidecalendar {
  border-color: #DDDDDD;
  background-color:#FFFFFF;
}

#calendar .maincalendar table.calendarmonth th {
  border-color: #000000;
}

table.minicalendar {
  border-color:#C0C0C0;
  background:#FFFFFF;
}

#calendar .maincalendar .eventlist .event {
  border-color:#C0C0C0;
}

#calendar .maincalendar .eventlist .event .topic,
#calendar .maincalendar .eventlist .event .picture,
#calendar .maincalendar .eventlist .event .side {
  background-color:#FFFFFF;
}

#calendar .maincalendar table.calendarmonth ul.events-underway {
  color:#999999;
}

#calendar .event_global,
.minicalendar .event_global,
.block_calendar_month .event_global {
  border-color:#2EBA0E !important;
  background-color:#2EBA0E;
}

#calendar .event_course,
.minicalendar .event_course,
.block_calendar_month .event_course {
  border-color:#FF9966 !important;
  background-color:#FF9966;
}

#calendar .event_group,
.minicalendar .event_group,
.block_calendar_month .event_group {
  border-color:#FBBB23 !important;
  background-color:#FBBB23;
}

#calendar .event_user,
.minicalendar .event_user,
.block_calendar_month .event_user {
  border-color:#A1BECB !important;
  background-color:#A1BECB;
}

#calendar .duration_global,
.minicalendar .duration_global {
  border-top-color:#2EBA0E !important;
  border-bottom-color:#2EBA0E !important;
}

#calendar .duration_course,
.minicalendar .duration_course {
  border-top-color:#FF9966 !important;
  border-bottom-color:#FF9966 !important;
}

#calendar .duration_group,
.minicalendar .duration_group {
  border-top-color:#FBBB23 !important;
  border-bottom-color:#FBBB23 !important;
}

#calendar .duration_user,
.minicalendar .duration_user {
  border-top-color:#A1BECB !important;
  border-bottom-color:#A1BECB !important;
}

#calendar .weekend,
.minicalendar .weekend {
  color:#FF0000;
}

#calendar .today,
.minicalendar .today {
  border-color:#000000 !important;
}

.cal_popup_fg {
  background-color:#FFFFFF;
}

.cal_popup_bg {
  border-color:#000000;
  background-color:#FFFFFF;
}

#calendar .maincalendar .filters table,
#calendar .sidecalendar .filters table,
.block_calendar_month .filters table {
  background-color: #FFFFFF;
}



/***
 *** Course
 ***/

/* course, entry-page, login */

/* course */
.headingblock .outline {
  border-color:#C0C0C0;
  color: #000000
}
h2.headingblock .header .outline {
  color: #000000
}

#course-view .section td {
  border-color:#C0C0C0;
}

#course-view .section .content {
  background-color: #FFFFFF;
}

#course-view .section .side {
  background-color: #FFFFFF;
}

#course-view .section .left {
}

#course-view .section .right {
}

#course-view .current .side{
  background-color: #FFD991;
}

#course-view .topics {
}

#course-view .weeks {
}

#course-view .section .spacer {
}

#course-view .section .weekdates {
}

.categoryboxcontent,
.coursebox {
  border-color:#C0C0C0;
  background-color: #FFFFFF;
}
body#course-user .section {
  border-color:#AAAAAA;
}

#course-report .plugin,
#course-import .plugin {
  margin-bottom: 20px;
  margin-left:10%;
  margin-right:10%;

  border-bottom: 1px solid #cecece;
  border-top: 1px solid #cecece;
  border-right: 1px solid #cecece;
  border-left: 1px solid #cecece;

  background-color: #fdfdfd;
}


/***
 *** Doc
 ***/

/***
 *** Grades
 ***/

body#grade-index .grades {
  border-color:black;
}

body#grade-index .grades td {
  border-color:#e0e0e0;
}

body#grade-index .grades .r0 {
  background-color: #ffffff;
}

body#grade-index .grades .r1 {
  background-color: #f0f0f0;
}


/***
 *** Login
 ***/

.loginbox,
.loginbox.twocolumns .loginpanel,
.loginbox .subcontent {
  border-color:#C0C0C0;
}

.loginbox .content {
  background-color: #FFFFFF;
}


/***
 *** Message
 ***/

table.message_search_results td {
  border-color:#C0C0C0;
}

.message.other .author {
  color: #8888CC;
}

.message.me .author {
  color: #999999;
}

.message .time {
  color: #999999;
}

.message .content {
}

/***
 *** Logs
 ***/

.logtable .r1 {
  background-color:#FFFFFF;
}


/***
 *** Tabs
 ***/

.tablink a:link,
.tablink a:visited {
  color:#888888;
}

.selected .tablink a:link,
.selected .tablink a:visited {
  color:#000000;
}
.tabs .side,
.tabrow td {
  border-color: #AAAAAA;
}
.tabrow td {
  background:url(pix/tab/left.gif) top left no-repeat;
}
.tabrow td .tablink {
  background:url(pix/tab/right.gif) top right no-repeat;
}
.tabrow td:hover {
  background-image:url(pix/tab/left_hover.gif);
}
.tabrow td:hover .tablink {
  background-image:url(pix/tab/right_hover.gif);
}
.tabrow .last {
  background: transparent url(pix/tab/right_end.gif) top right no-repeat;
}
.tabrow .selected {
  background:url(pix/tab/left_active.gif) top left no-repeat;
}
.tabrow .selected .tablink {
  background:url(pix/tab/right_active.gif) top right no-repeat;
}
.tabrow td.selected:hover {
  background-image:url(pix/tab/left_active_hover.gif);
}
.tabrow td.selected:hover .tablink {
  background-image:url(pix/tab/right_active_hover.gif);
}
.tabs .r0,
.tabs .r1 {
  background-color: #C0C0C0;
}

/***
 *** User
 ***/

.userpicture {
  background-color: #FFFFFF;
}

.userinfobox {
  border-color: #DDDDDD;
  background-color: #FFFFFF;
}
.groupinfobox {
  border-color: #DDDDDD;
}

#user-edit .formtable {
  background-color: #FFFFFF;
}

/***
 *** Modules: Chat
 ***/

#mod-chat-gui_header_js-jsupdate .text {
  color:#000
}
#mod-chat-gui_header_js-jsupdate .event,
#mod-chat-gui_header_js-jsupdate .title {
  color:#888
}

/***
 *** Modules: Choice
 ***/

/***
 *** Modules: Forum
 ***/

.forumheaderlist,
.forumpost {
  border-color:#C0C0C0;
}

.forumpost .content {
  background-color: #FFFFFF;
}

.forumpost .left {
  background-color:#C0C0C0;
}

.forumpost .topic {
  border-bottom-color: #C0C0C0;
}

.forumpost .starter {
  background-color:#C0C0C0;
}

.forumheaderlist .discussion .starter {
  background-color:#C0C0C0;
}

.forumheaderlist td {
  border-color: #FFFFFF;
}

.sideblock .post .head {
  color:#555555;
}

.forumthread .unread {
  background-color: #FFD991;
}
#mod-forum-discuss .forumpost {
  background-color: transparent;
}

#mod-forum-discuss .forumpost.unread .content {
  border-color: #FFD991;
} 

#mod-forum-discuss .forumthread .unread {
} 

#mod-forum-index .unread {
}

/***
 *** Modules: Glossary
 ***/

.entryboxheader {
  border-color: #BBBBBB;
}

.entrybox {
  border-color: #BBBBBB;
}

.entry {
}

.glossarypost {
  border-color: #DDDDDD;
}

.glossarypost .entryheader,
.glossarypost .entryapproval,
.glossarypost .picture,
.glossarypost .entryattachment,
.glossarypost .left {
  background-color: #F0F0F0;
}

.glossarycomment {
  border-color: #DDDDDD;
}

.glossarycomment .entryheader,
.glossarycomment .picture,
.glossarycomment .left {
  background-color: #F0F0F0;

}

.glossarycategoryheader {
  background-color: #dddddd;
}

.glossaryformatheader {
  background-color: #dddddd;
}


/***
 *** Modules: Journal
 ***/

#mod-journal-view .feedbackbox .left,
#mod-journal-view .feedbackbox .entryheader {
  background-color: #dddddd;
}

/***
 *** Modules: Label
 ***/

/***
 *** Modules: Lesson
 ***/

/***
 *** Modules: Quiz
 ***/

body#mod-quiz-report table#attempts td {
  border-color: #dddddd;
}
body#mod-quiz-report table#attempts .r1 {
  background-color: #FFFFFF;
}


/***
 *** Modules: Resource
 ***/

#mod-resource-view table {
  background-color: #FFFFFF;
}

.ims-nav-dimmed {
  color: #AAAAAA;
  text-decoration: none;
}

.ims-nav-button a:link,
.ims-nav-button a:visited,
.ims-nav-button a:hover {
  color: #000;
  text-decoration: none;
}

.ims-nav-dimmed,
.ims-nav-button a:link,
.ims-nav-button a:visited {
  border-top: 1px solid #cecece;
  border-bottom: 2px solid #4a4a4a;
  border-left: 1px solid #cecece;
  border-right: 2px solid #4a4a4a;
}

.ims-nav-button a:hover {
  border-bottom: 1px solid #cecece;
  border-top: 2px solid #4a4a4a;
  border-right: 1px solid #cecece;
  border-left: 2px solid #4a4a4a;
}


/***
 *** Modules: Scorm
 ***/

/***
 *** Modules: Survey
 ***/

#mod-survey-view .r0 {
  background-color: #FFFFFF;
}
#mod-survey-view .r1 {
  background-color: #DDDDDD;
}


/***
 *** Modules: Wiki
 ***/

/***
 *** Modules: Workshop
 ***/

.workshoppostpicture {
  background-color:#FEE6B9;
}

.workshopassessmentheading {
  background-color:#DDDDDD;
}

.error {
  color:#ff0000;
}

#left-column div.header, #right-column div.header {
	border: none;
	color:#FFFFFF;
}

#message-index #page,
#message-user #page,
#message-history #page,
#mod-glossary-showentry #page,
#help #page,
#course-info #page {
width:auto;
}/***** computer-scientist/styles_color.css end *****/

lang);
   
?>
