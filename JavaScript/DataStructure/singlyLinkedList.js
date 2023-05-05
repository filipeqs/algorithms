class SinglyLinkedListNode {
  constructor(val) {
    this.val = val;
    this.next = null;
  }
}

class SinglyLikedList {
  constructor() {
    this.head = null;
    this.tail = null;
    this.length = 0;
  }

  push(val) {
    var node = new SinglyLinkedListNode(val);

    if (this.length === 0) {
      this.head = node;
      this.tail = node;
    } else {
      const previousTail = this.tail;
      this.tail = node;
      previousTail.next = node;
    }

    this.length++;
    return this;
  }

  pop() {
    if (this.length === 0) return undefined;

    let current = this.head;
    let newTail = current;
    while (current.next) {
      newTail = current;
      current = current.next;
    }

    this.tail = newTail;
    this.tail.next = null;
    this.length--;
    return current;
  }

  unshift(val) {
    const node = new SinglyLinkedListNode(val);

    if (this.length === 0) {
      this.head = node;
      this.tail = node;
    } else {
      node.next = this.head;
      this.head = node;
    }

    this.length++;
    return this;
  }

  shift() {
    if (this.length === 0) return undefined;

    const currentHead = this.head;
    this.head = this.head.next;
    this.length--;

    if (this.length === 0) {
      this.tail = null;
    }

    return currentHead;
  }

  get(position) {
    if (position < 0 || position > this.length) return undefined;
    let i = 0;
    let current = this.head;
    while (i !== position) {
      current = current.next;
      i++;
    }

    return current;
  }

  set(index, val) {
    const node = this.get(index);
    if (node) {
      node.val = val;
      return true;
    }

    return false;
  }

  insert(index, val) {
    if (index < 0 || index >= this.length) return false;
    if (index === this.length) return !!this.push(val);
    if (index === 0) return !!this.unshift(val);

    const newNode = new SinglyLinkedListNode(val);
    const prev = this.get(index - 1);
    const temp = prev.next;
    prev.next = newNode;
    newNode.next = temp;
    this.length++;
    return true;
  }

  remove(index) {
    if (index < 0 || index >= this.length) return false;
    if (index === this.length - 1) return !!this.pop();
    if (index === 0) return !!this.shift();

    const prevNode = this.get(index - 1);
    const removed = prevNode.next;
    prevNode.next = removed.next;
    this.length--;

    return removed;
  }

  reverse() {
    let current = this.head;
    this.head = this.tail;
    this.tail = current;

    let prev = null;
    while (current) {
      const next = current.next;
      current.next = prev;
      prev = current;
      current = next;
    }

    return this;
  }
}

const singlyList = new SinglyLikedList();
singlyList.push('Hi');
singlyList.push('there');
singlyList.push('Its');
