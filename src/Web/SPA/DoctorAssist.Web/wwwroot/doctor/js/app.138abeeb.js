(function(e){function t(t){for(var n,r,s=t[0],l=t[1],c=t[2],u=0,d=[];u<s.length;u++)r=s[u],o[r]&&d.push(o[r][0]),o[r]=0;for(n in l)Object.prototype.hasOwnProperty.call(l,n)&&(e[n]=l[n]);p&&p(t);while(d.length)d.shift()();return i.push.apply(i,c||[]),a()}function a(){for(var e,t=0;t<i.length;t++){for(var a=i[t],n=!0,r=1;r<a.length;r++){var s=a[r];0!==o[s]&&(n=!1)}n&&(i.splice(t--,1),e=l(l.s=a[0]))}return e}var n={},r={app:0},o={app:0},i=[];function s(e){return l.p+"js/"+({about:"about",manage:"manage",profile:"profile","profile.details":"profile.details","profile.docs":"profile.docs"}[e]||e)+"."+{about:"1ea623c7","chunk-2d0bcea4":"3b9f1c92",manage:"e7151bad",profile:"1837834c","profile.details":"75075396","profile.docs":"b481714c"}[e]+".js"}function l(t){if(n[t])return n[t].exports;var a=n[t]={i:t,l:!1,exports:{}};return e[t].call(a.exports,a,a.exports,l),a.l=!0,a.exports}l.e=function(e){var t=[],a={about:1};r[e]?t.push(r[e]):0!==r[e]&&a[e]&&t.push(r[e]=new Promise(function(t,a){for(var n="css/"+({about:"about",manage:"manage",profile:"profile","profile.details":"profile.details","profile.docs":"profile.docs"}[e]||e)+"."+{about:"4e52a42d","chunk-2d0bcea4":"31d6cfe0",manage:"31d6cfe0",profile:"31d6cfe0","profile.details":"31d6cfe0","profile.docs":"31d6cfe0"}[e]+".css",o=l.p+n,i=document.getElementsByTagName("link"),s=0;s<i.length;s++){var c=i[s],u=c.getAttribute("data-href")||c.getAttribute("href");if("stylesheet"===c.rel&&(u===n||u===o))return t()}var d=document.getElementsByTagName("style");for(s=0;s<d.length;s++){c=d[s],u=c.getAttribute("data-href");if(u===n||u===o)return t()}var p=document.createElement("link");p.rel="stylesheet",p.type="text/css",p.onload=t,p.onerror=function(t){var n=t&&t.target&&t.target.src||o,i=new Error("Loading CSS chunk "+e+" failed.\n("+n+")");i.request=n,delete r[e],p.parentNode.removeChild(p),a(i)},p.href=o;var f=document.getElementsByTagName("head")[0];f.appendChild(p)}).then(function(){r[e]=0}));var n=o[e];if(0!==n)if(n)t.push(n[2]);else{var i=new Promise(function(t,a){n=o[e]=[t,a]});t.push(n[2]=i);var c,u=document.createElement("script");u.charset="utf-8",u.timeout=120,l.nc&&u.setAttribute("nonce",l.nc),u.src=s(e),c=function(t){u.onerror=u.onload=null,clearTimeout(d);var a=o[e];if(0!==a){if(a){var n=t&&("load"===t.type?"missing":t.type),r=t&&t.target&&t.target.src,i=new Error("Loading chunk "+e+" failed.\n("+n+": "+r+")");i.type=n,i.request=r,a[1](i)}o[e]=void 0}};var d=setTimeout(function(){c({type:"timeout",target:u})},12e4);u.onerror=u.onload=c,document.head.appendChild(u)}return Promise.all(t)},l.m=e,l.c=n,l.d=function(e,t,a){l.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:a})},l.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},l.t=function(e,t){if(1&t&&(e=l(e)),8&t)return e;if(4&t&&"object"===typeof e&&e&&e.__esModule)return e;var a=Object.create(null);if(l.r(a),Object.defineProperty(a,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var n in e)l.d(a,n,function(t){return e[t]}.bind(null,n));return a},l.n=function(e){var t=e&&e.__esModule?function(){return e["default"]}:function(){return e};return l.d(t,"a",t),t},l.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},l.p="/doctor/",l.oe=function(e){throw console.error(e),e};var c=window["webpackJsonp"]=window["webpackJsonp"]||[],u=c.push.bind(c);c.push=t,c=c.slice();for(var d=0;d<c.length;d++)t(c[d]);var p=u;i.push([0,"chunk-vendors"]),a()})({0:function(e,t,a){e.exports=a("cd49")},"41cb":function(e,t,a){"use strict";a("cadf"),a("551c"),a("097d");var n=a("2b0e"),r=a("8c4f"),o=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("section",{staticClass:"section"},[a("div",{staticClass:"container"},[a("h1",{staticClass:"title is-primary"},[e._v("Section")]),a("arti",{staticClass:"tile is-ancestor"},[a("article",{staticClass:"tile is-child box is-5"},[a("p",{staticClass:"title"},[e._v("Today...")]),a("p")]),a("article",{staticClass:"tile is-child box is-5"},[a("p",{staticClass:"title"},[e._v("Search")]),a("p")])])],1)])},i=[],s=a("d4ec"),l=a("99de"),c=a("7e84"),u=a("262e"),d=a("60a3"),p=function(e){function t(){return Object(s["a"])(this,t),Object(l["a"])(this,Object(c["a"])(t).apply(this,arguments))}return Object(u["a"])(t,e),t}(d["c"]),f=p,h=a("2877"),b=Object(h["a"])(f,o,i,!1,null,null,null);b.options.__file="Home.vue";var m=b.exports;n["default"].use(r["a"]);t["a"]=new r["a"]({mode:"history",base:"/doctor/",routes:[{path:"/",name:"home",component:m},{path:"/Doctor/Home",redirect:"/"},{path:"/clients",name:"clients",component:function(){return a.e("about").then(a.bind(null,"58f3"))}},{path:"/profile",component:function(){return a.e("profile").then(a.bind(null,"c66d"))},children:[{path:"",name:"profile",component:function(){return a.e("chunk-2d0bcea4").then(a.bind(null,"2a87"))}},{path:"details",name:"patient-details",component:function(){return a.e("profile.details").then(a.bind(null,"33e0"))}},{path:"docs",name:"patient-docs",component:function(){return a.e("profile.docs").then(a.bind(null,"aa15"))}}]},{path:"/manage",component:function(){return a.e("manage").then(a.bind(null,"f74b"))},children:[{path:"forms",name:"manage-forms",component:function(){return a.e("manage").then(a.bind(null,"d74a"))}}]}]})},"845f":function(e,t,a){},cd49:function(e,t,a){"use strict";a.r(t);a("cadf"),a("551c"),a("097d");var n=a("2b0e"),r=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",{attrs:{id:"app"}},[a("nav",{staticClass:"navbar is-primary shadow",attrs:{role:"navigation","aria-label":"main navigation"}},[a("div",{staticClass:"navbar-brand"},[a("a",{staticClass:"navbar-item",attrs:{href:"#"}},[a("img",{attrs:{src:"{{this.$user.logo}}",width:"112",height:"28"}}),e._v("\n                "+e._s(this.$user.userName)+" - "+e._s(this.$user.userRole)+"\n            ")]),e._m(0)]),a("div",{staticClass:"navbar-menu",attrs:{id:"navbarMain"}},[a("div",{staticClass:"navbar-start"},[a("router-link",{staticClass:"navbar-item",attrs:{to:"/"}},[e._v("Home")]),a("router-link",{staticClass:"navbar-item",attrs:{to:"/clients"}},[e._v("Clients")])],1),a("div",{staticClass:"navbar-end"},[a("div",{staticClass:"navbar-item has-dropdown is-hoverable"},[a("a",{staticClass:"navbar-link"},[e._v("\n                        Manage\n                    ")]),a("div",{staticClass:"navbar-dropdown"},[a("router-link",{staticClass:"navbar-item",attrs:{to:"/manage/forms"}},[e._v("Forms")])],1)]),a("div",{staticClass:"navbar-item"},[a("div",{staticClass:"buttons"},[a("a",{staticClass:"button is-dark",on:{click:function(t){e.logOut()}}},[e._v("\n                            Log out\n                        ")])])])])])]),a("router-view")],1)},o=[function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("a",{staticClass:"navbar-burger burger",attrs:{role:"button","aria-label":"menu","aria-expanded":"false","data-target":"navbarMain"}},[a("span",{attrs:{"aria-hidden":"true"}}),a("span",{attrs:{"aria-hidden":"true"}}),a("span",{attrs:{"aria-hidden":"true"}})])}],i=a("2877"),s={},l=Object(i["a"])(s,r,o,!1,null,null,null);l.options.__file="App.vue";var c=l.exports,u=a("41cb"),d=a("2f62");n["default"].use(d["a"]);var p=new d["a"].Store({state:{},mutations:{},actions:{}}),f=a("bc3a"),h=a.n(f),b=a("b383"),m=a.n(b);a("845f");n["default"].config.productionTip=!1,n["default"].prototype.$user={},n["default"].prototype.$header={},n["default"].prototype.$http={},n["default"].mixin({data:function(){return{clientToken:""}},methods:{logOut:function(){alert("I'm a global function")}}});var v={grant_type:"client_credentials",client_id:"doctor-web",client_secret:"aSBhbSBhIGRvY3Rvcg=="};new n["default"]({router:u["a"],store:p,beforeCreate:function(){n["default"].prototype.$user=JSON.parse(sessionStorage.getItem("data")),console.log(n["default"].prototype.$user),h.a.post(n["default"].prototype.$user.apiPath+"connect/token",m.a.stringify(v,"&","=",null)).then(function(e){console.log(e.data),n["default"].prototype.$header="bearer "+e.data.access_token,console.log("userresponse "+e.data.access_token)}).catch(function(e){console.log("error "+e)}),n["default"].prototype.$http=h.a.create({baseURL:n["default"].prototype.$user.apiPath,timeout:5e3,headers:{Authorization:n["default"].prototype.$header,"Content-Type":"application/json"}})},render:function(e){return e(c)}}).$mount("#app")}});
//# sourceMappingURL=app.138abeeb.js.map