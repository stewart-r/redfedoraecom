"use strict";

exports.__esModule = true;
exports.GridCtrl = exports.GridDirective = undefined;

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

var _fableCore = require("fable-core");

var _product = require("./product");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var GridDirective = exports.GridDirective = function () {
    function GridDirective() {
        _classCallCheck(this, GridDirective);

        this["templateUrl@"] = "products/grid.html";
        this["restrict@"] = "EA";
    }

    GridDirective.GetInstance = function GetInstance() {
        return new GridDirective();
    };

    _createClass(GridDirective, [{
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
                return GridDirective.GetInstance();
            }]];
        }
    }]);

    return GridDirective;
}();

_fableCore.Util.setInterfaces(GridDirective.prototype, ["AngularFable.NgFable.IDirective"], "GridView.GridDirective");

var GridCtrl = exports.GridCtrl = function () {
    function GridCtrl(http) {
        _classCallCheck(this, GridCtrl);

        var products = Array.from(_fableCore.Seq.delay(function () {
            return _fableCore.Seq.map(function (i) {
                var name = _fableCore.String.fsFormat("product%d")(function (x) {
                    return x;
                })(i);

                var desc = _fableCore.String.fsFormat("some description of %d")(function (x) {
                    return x;
                })(i);

                var imgUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcS6CmRDXEWsVbQ7xwJV1fj7Bci_WxMAsj2nwxglWu-SG5K8dFjbCsE8ss4";
                return new _product.Product(name, desc, imgUrl);
            }, _fableCore.Seq.range(1, 26));
        }));
        this._rows = Array.from(_fableCore.Seq.delay(function () {
            return _fableCore.Seq.map(function (i) {
                return products.slice(i * 3).slice(0, 3);
            }, _fableCore.Seq.range(0, ~~(products.length / 3) + 1));
        }));
        this["Http@"] = http;
    }

    GridCtrl.prototype.rows = function rows() {
        return this._rows;
    };

    GridCtrl.GetInstance = function GetInstance(http) {
        return new GridCtrl(http);
    };

    _createClass(GridCtrl, [{
        key: "Http",
        get: function get() {
            return this["Http@"];
        },
        set: function set(v) {
            this["Http@"] = v;
        }
    }], [{
        key: "Factory",
        get: function get() {
            return ["$http", function (arg00) {
                return GridCtrl.GetInstance(arg00);
            }];
        }
    }]);

    return GridCtrl;
}();

_fableCore.Util.setInterfaces(GridCtrl.prototype, [], "GridView.GridCtrl");
//# sourceMappingURL=grid.js.map