"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
var UserService = (function () {
    function UserService(http) {
        this.http = http;
        this.tokenKey = "token";
    }
    UserService.prototype.getUserProfile = function () {
        return this.http.get("api/Profile").toPromise().then(function (response) {
            var result = response.json();
            if (result.state == 0) {
            }
            return result;
        });
    };
    UserService.prototype.removeWish = function (wishEventId) {
        var requestParams = new http_1.URLSearchParams();
        requestParams.append('wishEventId', wishEventId);
        return this.http.delete("api/Profile/RemoveWish", { params: requestParams }).toPromise().then(function (response) {
            var result = response.json();
            if (result.state == 0) {
            }
            return result;
        });
    };
    return UserService;
}());
UserService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], UserService);
exports.UserService = UserService;
//# sourceMappingURL=user.service.js.map