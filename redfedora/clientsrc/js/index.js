"use strict";

exports.__esModule = true;
exports.value1 = exports.someRefTof1 = exports.TestCtrl = exports.app = undefined;
exports.f1 = f1;
exports.f2 = f2;

var _angular = require("angular");

var angular = _interopRequireWildcard(_angular);

var _fableCore = require("fable-core");

function _interopRequireWildcard(obj) { if (obj && obj.__esModule) { return obj; } else { var newObj = {}; if (obj != null) { for (var key in obj) { if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key]; } } newObj.default = obj; return newObj; } }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var app = exports.app = angular.module("app", []);

var TestCtrl = exports.TestCtrl = function () {
    function TestCtrl() {
        _classCallCheck(this, TestCtrl);
    }

    TestCtrl.prototype.Val1 = function Val1() {
        return "boom";
    };

    return TestCtrl;
}();

_fableCore.Util.setInterfaces(TestCtrl.prototype, [], "App.TestCtrl");

    function f1() {
        return 1;
    }

    var someRefTof1 = exports.someRefTof1 = function someRefTof1(arg00_) {
        return f1(arg00_);
    };

function f2(f, x) {
    var a = f();
    return a * a;
}

var value1 = exports.value1 = f2(function (arg00_) {
    return f1(arg00_);
}, 1);
//# sourceMappingURL=index.js.map