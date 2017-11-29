"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var app_component_1 = require("./components/app/app.component");
var top_navigation_component_1 = require("./components/top-navigation/top-navigation.component");
var main_component_1 = require("./components/main/main.component");
var sign_in_component_1 = require("./components/sign-in/sign-in.component");
var sign_up_component_1 = require("./components/sign-up/sign-up.component");
var profile_component_1 = require("./components/profile/profile.component");
var last_publications_component_1 = require("./components/last-publications/last-publications.component");
var appRoutes = [
    { path: '', redirectTo: 'main', pathMatch: 'full' },
    { path: 'main', component: main_component_1.MainComponent },
    { path: 'sign-in', component: sign_in_component_1.SignInComponent },
    { path: 'sign-up', component: sign_up_component_1.SignUpComponent },
    { path: 'profile', component: profile_component_1.ProfileComponent },
    { path: 'last-publications', component: last_publications_component_1.LastPublicationsComponent }
];
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        declarations: [
            app_component_1.AppComponent,
            top_navigation_component_1.TopNavigationComponent,
            main_component_1.MainComponent,
            sign_in_component_1.SignInComponent,
            sign_up_component_1.SignUpComponent,
            profile_component_1.ProfileComponent,
            last_publications_component_1.LastPublicationsComponent
        ],
        imports: [
            router_1.RouterModule.forRoot(appRoutes, { enableTracing: true }),
            platform_browser_1.BrowserModule
        ],
        providers: [],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map