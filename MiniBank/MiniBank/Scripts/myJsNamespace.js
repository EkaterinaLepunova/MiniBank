var anchorChanger = function() {
    this.init();
};

anchorChanger.prototype.config = {
    colors: ["#AA9", "#987", "#00D"]
};

anchorChanger.prototype.changeColor = function(curAnchor, newColor) {
    curAnchor.style.backgroundColor = newColor;
};

anchorChanger.prototype.init = function() {
    var self = this;
    var anchors = document.getElementsByTagName("a");
    var size = anchors.length;
    for (var i = 0; i < size; i++) {
        anchors[i].color = self.config.colors[i];
        anchors[i].onclick = function() {
            self.changeColor(this, this.color);
            return false;
        };
    }
};

