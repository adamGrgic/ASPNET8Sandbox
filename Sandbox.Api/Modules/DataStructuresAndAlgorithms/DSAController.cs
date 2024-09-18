using Microsoft.AspNetCore.Mvc;
using Sandbox.Api.Modules.DataStructuresAndAlgorithms.BinarySearchTree;

[ApiController]
[Route("api/[controller]")]
public class DSAController : ControllerBase
{
    private readonly IBinarySearchTree _binarySearchTree;

    public DSAController(IBinarySearchTree binarySearchTree)
    {
        _binarySearchTree = binarySearchTree;
    }

    [HttpPost("execute")]
    public IActionResult ExecuteOperations([FromBody] BinarySearchTreeRequest request)
    {
        // Call the method that executes the tree operations
        var result = _binarySearchTree.ExecuteTreeOperations(request.ValuesToInsert, request.ValueToSearch);

        // Return the results as a JSON object
        return Ok(new
        {
            Traversal = result.Traversal,
            SearchResult = result.SearchResult,
            Tree = result.Tree // This will serialize the tree as a nested JSON object
        });
    }
}

// Request object to handle inputs from the API
public class BinarySearchTreeRequest
{
    public int[] ValuesToInsert { get; set; }
    public int ValueToSearch { get; set; }
}
