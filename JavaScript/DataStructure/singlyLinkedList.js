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

    const nodeToReturn = this.tail;
    let current = this.head;
    let i = 1;
    while (i < this.length - 1) {
      current = current.next;
      i++;
    }

    this.tail = current;
    this.length--;
    if (this.length === 0) {
      this.head = null;
      this.tail = null;
    }

    return nodeToReturn;
  }

  shift(val) {
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

  unshift() {
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
    let i = 1;
    let current = this.head;
    while (i !== position) {
      current = current.next;
      i++;
    }

    return current;
  }

  set(position, val) {
    const node = this.get(position);
    if (node) {
      node.val = val;
      return true;
    }

    return false;
  }

  insert(position, val) {
    if (position < 0 || position > this.length) return false;
    if (position === this.length) return !!this.push(val);
    if (position === 0) return !!this.unshift(val);

    const newNode = new SinglyLinkedListNode(val);
    const prev = this.get(position - 1);
    const temp = prev.next;
    prev.next = newNode;
    newNode.next = temp;
    this.length++;
    return true;
  }
}

const singlyList = new SinglyLikedList();
singlyList.push('Hi');
singlyList.push('there');
singlyList.push('Its');
singlyList.shift('Hello');
singlyList.set(1, 'test');
console.log(singlyList);
