# OrderingApi

Design to sort and save to file given numbers.

## How it works:

- We have 4 enpdoints:

## Swagger

`swagger` [/swagger/index.html](#/swagger/index.html) <br/>

## GET

`get latest numbers from file` [/api](#/api) <br/>

## POST

`post numbers` [/api?numbers=1 2 3](#/api?numbers=1 2 3) <br/>

- Input:

```shell
    numbers=5 2 8 10 1
```

- Returns:

```shell
    1 2 5 8 10
```

`post numbers and measure performance` [/api/measure?numbers=1 2 3](#/api/measure?numbers=1 2 3) <br/>

- Input:

```shell
    numbers=5 2 8 10 1
```

- Returns:

```shell
    {
    "bubbleSortTime": 0,
    "insertionSortTime": 0,
    "shellSortTime": 0,
    "quickSortTime": 0,
    "result": "1 2 5 8 10"
}
```

## How to start

- Using visual studio

- On linux or mac simply type:

```shell
    bash run.sh
```

- To run tests:

```shell
    bash run.sh test
```
