"use strict";

exports.__esModule = true;
exports.GridCellCtrl = exports.GridCellDirective = undefined;

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

var _fableCore = require("fable-core");

var _product = require("./product");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var GridCellDirective = exports.GridCellDirective = function () {
    function GridCellDirective() {
        _classCallCheck(this, GridCellDirective);

        this["templateUrl@"] = "products/gridCell.html";
        this["restrict@"] = "EA";
    }

    GridCellDirective.GetInstance = function GetInstance() {
        return new GridCellDirective();
    };

    _createClass(GridCellDirective, [{
        key: "templateUrl",
        get: function get() {
            return this["templateUrl@"];
        },
        set: function set(v) {
            this["templateUrl@"] = v;
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
            return [["", function () {
                return GridCellDirective.GetInstance();
            }]];
        }
    }]);

    return GridCellDirective;
}();

_fableCore.Util.setInterfaces(GridCellDirective.prototype, ["AngularFable.NgFable.IDirective"], "GridCellView.GridCellDirective");

var GridCellCtrl = exports.GridCellCtrl = function () {
    function GridCellCtrl(scope) {
        _classCallCheck(this, GridCellCtrl);

        this["Scope@"] = scope;
    }

    GridCellCtrl.GetInstance = function GetInstance(scope) {
        var ret = new GridCellCtrl(scope);
        ret.Scope.product = new _product.Product("My Title", "My Description");
        return ret;
    };

    _createClass(GridCellCtrl, [{
        key: "Scope",
        get: function get() {
            return this["Scope@"];
        },
        set: function set(v) {
            this["Scope@"] = v;
        }
    }], [{
        key: "Factory",
        get: function get() {
            return ["$scope", function (arg00) {
                return GridCellCtrl.GetInstance(arg00);
            }];
        }
    }]);

    return GridCellCtrl;
}();

_fableCore.Util.setInterfaces(GridCellCtrl.prototype, [], "GridCellView.GridCellCtrl");
//# sourceMappingURL=gridViewCell.js.map