'use strict';

//var storage = new Service();
//storage.add(); //��������� ������ � ��������� �������� ��� � ���������
//storage.getById(); //��������� id � ���������� ��������� ������ ��� NULL ���� �� ������
//stotage.getAll(); //���������� ���� ������ ��������
//storage.deleteById(); //��������� id � ���������� ��������� ������
//storage.updateById(); // ��������� id ������ ���������� � ������-������. ��������� ���� ������� ������ ����������
//storage.replaceById(); // ��������� id � �������� ������ ������ - �����

class Service {
    constructor() {
        this.items = new Array();
        this.id = 0;
    }

    checkId(id) {
        return typeof id === "string";
    }

    checkObj(obj) {
        return typeof obj === "object" && obj != null;
    }

    add(obj) {
        if (this.checkObj(obj)) {
            this.id++;
            obj.id = "id" + this.id;
            this.items.push(obj);
        }
    }

    searchById(id) {
        for (let i = 0; i < this.items.length; i++) {
            if (this.items[i].id == id) {
                return this.items[i];
            }
        }
        return null;
    }

    getById(id) {
        if (this.checkId(id)) {
            return this.searchById(id);
        }
    }

    getAll() {
        return this.items;
    }

    deleteById(id) {
        if (this.checkId(id)) {
            let temp = this.searchById(id);
            if (temp != null) {
                this.items.splice(this.items.indexOf(temp), 1);
                return temp;
            }
        }
    }

    updateById(id, obj) {
        if (this.checkId(id) && this.checkObj(obj)) {
            let temp = this.searchById(id);
            if (temp != null) {
                for (let prop in obj) {
                    temp[prop] = obj[prop];
                }
            }
        }
    }

    replaceById(id, obj) {
        if (this.checkId(id) && this.checkObj(obj)) {
            let temp = this.searchById(id);
            if (temp != null) {
                obj.id = id;
                this.items[this.items.indexOf(temp)] = obj;
            }
        }
    }
}

module.exports = Service;