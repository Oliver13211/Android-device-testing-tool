# This Python file uses the following encoding: utf-8
import sys
import os
import time

from PySide6.QtWidgets import QApplication, QWidget

# Important:
# You need to run the following command to generate the ui_form.py file
#     pyside6-uic form.ui -o ui_form.py, or
#     pyside2-uic form.ui -o ui_form.py
from ui_form import Ui_Widget

class Widget(QWidget):
    def __init__(self, parent=None):
        super().__init__(parent)
        self.ui = Ui_Widget()
        self.ui.setupUi(self)
        self.ui.pushButton.clicked.connect(self.push_button_command)
        self.ui.textEdit.setReadOnly(True)


    def push_button_command(self):
        # print(self.ui.spinBox.value())
        num = self.ui.spinBox.value()
        ifpass, iffail = 0, 0
        # print(num)
        self.ui.textEdit.setText('正在测试中')
        for i in range(1, num + 1):
            if int(os.system('adb reboot')) == 1:
                iffail += 1
            else:
                ifpass += 1
        self.ui.textEdit.setText(f'测试完毕，成功{ifpass}次，失败{iffail}次')



if __name__ == "__main__":
    app = QApplication(sys.argv)
    widget = Widget()
    widget.show()
    sys.exit(app.exec())
