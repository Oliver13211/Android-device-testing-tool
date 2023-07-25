# -*- coding: utf-8 -*-

################################################################################
## Form generated from reading UI file 'form.ui'
##
## Created by: Qt User Interface Compiler version 6.5.1
##
## WARNING! All changes made in this file will be lost when recompiling UI file!
################################################################################

from PySide6.QtCore import (QCoreApplication, QDate, QDateTime, QLocale,
    QMetaObject, QObject, QPoint, QRect,
    QSize, QTime, QUrl, Qt)
from PySide6.QtGui import (QBrush, QColor, QConicalGradient, QCursor,
    QFont, QFontDatabase, QGradient, QIcon,
    QImage, QKeySequence, QLinearGradient, QPainter,
    QPalette, QPixmap, QRadialGradient, QTransform)
from PySide6.QtWidgets import (QApplication, QLabel, QPushButton, QSizePolicy,
    QSpinBox, QTextEdit, QWidget)

class Ui_Widget(object):
    def setupUi(self, Widget):
        if not Widget.objectName():
            Widget.setObjectName(u"Widget")
        Widget.resize(585, 604)
        self.lbl1 = QLabel(Widget)
        self.lbl1.setObjectName(u"lbl1")
        self.lbl1.setGeometry(QRect(30, 30, 131, 71))
        font = QFont()
        font.setPointSize(20)
        self.lbl1.setFont(font)
        self.lbl2 = QLabel(Widget)
        self.lbl2.setObjectName(u"lbl2")
        self.lbl2.setGeometry(QRect(170, 160, 91, 51))
        font1 = QFont()
        font1.setPointSize(15)
        self.lbl2.setFont(font1)
        self.spinBox = QSpinBox(Widget)
        self.spinBox.setObjectName(u"spinBox")
        self.spinBox.setGeometry(QRect(290, 180, 51, 21))
        self.pushButton = QPushButton(Widget)
        self.pushButton.setObjectName(u"pushButton")
        self.pushButton.setGeometry(QRect(40, 510, 141, 31))
        self.textEdit = QTextEdit(Widget)
        self.textEdit.setObjectName(u"textEdit")
        self.textEdit.setGeometry(QRect(120, 230, 271, 251))
        font2 = QFont()
        font2.setPointSize(16)
        self.textEdit.setFont(font2)

        self.retranslateUi(Widget)

        QMetaObject.connectSlotsByName(Widget)
    # setupUi

    def retranslateUi(self, Widget):
        Widget.setWindowTitle(QCoreApplication.translate("Widget", u"Widget", None))
        self.lbl1.setText(QCoreApplication.translate("Widget", u"\u91cd\u542f", None))
        self.lbl2.setText(QCoreApplication.translate("Widget", u" \u91cd\u542f\u6b21\u6570\uff1a", None))
        self.pushButton.setText(QCoreApplication.translate("Widget", u"\u5f00\u59cb", None))
        self.textEdit.setHtml(QCoreApplication.translate("Widget", u"<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n"
"<html><head><meta name=\"qrichtext\" content=\"1\" /><meta charset=\"utf-8\" /><style type=\"text/css\">\n"
"p, li { white-space: pre-wrap; }\n"
"hr { height: 1px; border-width: 0; }\n"
"li.unchecked::marker { content: \"\\2610\"; }\n"
"li.checked::marker { content: \"\\2612\"; }\n"
"</style></head><body style=\" font-family:'Microsoft YaHei UI'; font-size:16pt; font-weight:400; font-style:normal;\">\n"
"<p style=\" margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\">\u8f93\u51fa\u533a</p>\n"
"<p style=\"-qt-paragraph-type:empty; margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\"><br /></p></body></html>", None))
    # retranslateUi

