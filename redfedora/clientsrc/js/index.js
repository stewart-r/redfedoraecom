"use strict";

exports.__esModule = true;
exports.TestDirective = exports.TestCtrl = exports.app = undefined;

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

var _angular = require("angular");

var angular = _interopRequireWildcard(_angular);

var _fableCore = require("fable-core");

function _interopRequireWildcard(obj) { if (obj && obj.__esModule) { return obj; } else { var newObj = {}; if (obj != null) { for (var key in obj) { if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key]; } } newObj.default = obj; return newObj; } }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var app = exports.app = angular.module("app", []);

var TestCtrl = exports.TestCtrl = function () {
    function TestCtrl(http) {
        _classCallCheck(this, TestCtrl);

        this.http = http;
        this.str = "not retrieved yet";
    }

    TestCtrl.prototype.Val1 = function Val1() {
        return "boom";
    };

    TestCtrl.prototype.Val2 = function Val2() {
        return this.str;
    };

    TestCtrl.prototype.Fetch = function Fetch() {
        var _this = this;

        return this.Http.get("/api/ss").then(function (r) {
            _this.str = _fableCore.Util.toString(r.data);
        });
    };

    TestCtrl.GetInstance = function GetInstance(http) {
        return new TestCtrl(http);
    };

    _createClass(TestCtrl, [{
        key: "Http",
        get: function get() {
            return this.http;
        }
    }], [{
        key: "Factory",
        get: function get() {
            return ["$http", function (arg00) {
                return TestCtrl.GetInstance(arg00);
            }];
        }
    }]);

    return TestCtrl;
}();

_fableCore.Util.setInterfaces(TestCtrl.prototype, [], "App.TestCtrl");

var TestDirective = exports.TestDirective = function () {
    function TestDirective() {
        _classCallCheck(this, TestDirective);

        this["template@"] = "<b>Im coming from the directive!</b>";
        this["restrict@"] = "EA";
    }

    TestDirective.GetInstance = function GetInstance() {
        return new TestDirective();
    };

    _createClass(TestDirective, [{
        key: "template",
        get: function get() {
            return this["template@"];
        },
        set: function set(v) {
            this["template@"] = v;
        }
    }, {
        key: "restrict",
        get: function get() {
            return this["restrict@"];
        },
        set: function set(v) {
            this["restrict@"] = v;
        }
    }], [{
        key: "Factory",
        get: function get() {
            return [["", function (arg00) {
                return TestCtrl.GetInstance(arg00);
            }]];
        }
    }]);

    return TestDirective;
}();

_fableCore.Util.setInterfaces(TestDirective.prototype, ["AngularFable.NgFable.IDirective"], "App.TestDirective");

app.controller("test", TestCtrl.Factory);
app.directive("testDirective", function () {
    return TestDirective.GetInstance();
});
//# sourceMappingURL=index.js.map