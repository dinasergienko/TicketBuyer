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
var forms_1 = require("@angular/forms");
var router_1 = require("@angular/router");
var event_service_1 = require("../../services/event.service");
var AddEventComponent = (function () {
    function AddEventComponent(eventService, formBuilder, router) {
        this.eventService = eventService;
        this.formBuilder = formBuilder;
        this.router = router;
    }
    AddEventComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.form = this.formBuilder.group({
            title: ['', forms_1.Validators.required],
            information: ['', forms_1.Validators.required],
            datetime: ['', forms_1.Validators.required],
            type: ['', forms_1.Validators.required],
            placeId: ['', forms_1.Validators.required]
        });
        this.eventService.getEventFiltersData().then(function (response) {
            var result = response.json();
            if (result.state == 1) {
                _this.eventFiltersData = result.data;
            }
            else {
                _this.errorMessage = result.message;
            }
        });
    };
    AddEventComponent.prototype.fileChange = function (event) {
        this.fileList = event.target.files;
    };
    AddEventComponent.prototype.onSubmit = function () {
        var _this = this;
        this.eventService.addEvent(this.form.get('title').value, this.form.get('information').value, this.form.get('datetime').value, this.form.get('type').value, this.form.get('placeId').value).then(function (response) {
            var result = response.json();
            if (result.state == 1) {
                _this.router.navigate(["/main"]);
            }
            else {
                _this.errorMessage = result.message;
            }
        });
    };
    return AddEventComponent;
}());
AddEventComponent = __decorate([
    core_1.Component({
        selector: 'add-event',
        templateUrl: './add-event.component.html',
        styleUrls: ['./add-event.component.scss']
    }),
    __metadata("design:paramtypes", [event_service_1.EventService,
        forms_1.FormBuilder,
        router_1.Router])
], AddEventComponent);
exports.AddEventComponent = AddEventComponent;
//# sourceMappingURL=add-event.component.js.map