"use strict";

exports.__esModule = true;
exports.TestCtrl = exports.app = undefined;

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

app.controller("test", TestCtrl);
//# sourceMappingURL=index.js.map