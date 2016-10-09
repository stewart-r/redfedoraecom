"use strict";

var _app = require("./app");

var _gridViewCell = require("./products/gridViewCell");

var _grid = require("./products/grid");

_app.app.controller("gridCellCtrl", _gridViewCell.GridCellCtrl.Factory);

_app.app.directive("gridCell", function () {
  return _gridViewCell.GridCellDirective.GetInstance();
});

_app.app.controller("gridCtrl", _grid.GridCtrl.Factory);

_app.app.directive("grid", function () {
  return _grid.GridDirective.GetInstance();
});
//# sourceMappingURL=index.js.map